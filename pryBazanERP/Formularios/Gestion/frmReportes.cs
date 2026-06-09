using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmReportes : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly bool esAdministrador;
        private readonly List<classConexion.UsuarioItem> usuarios = new List<classConexion.UsuarioItem>();
        private readonly List<classConexion.PersonalItem> personal = new List<classConexion.PersonalItem>();
        private readonly List<classConexion.AuditoriaItem> auditorias = new List<classConexion.AuditoriaItem>();

        public frmReportes() : this(false)
        {
        }

        public frmReportes(bool esAdministrador)
        {
            this.esAdministrador = esAdministrador;
            InitializeComponent();
            AppIcon.Aplicar(this);
            AplicarEstiloGrid(dgvPerfiles);
            AplicarEstiloGrid(dgvProvincias);
            AplicarEstiloGrid(dgvContactos);

            if (!this.esAdministrador)
            {
                BloquearSinPermiso();
                return;
            }

            CargarDatos();
        }

        private void CargarDatos()
        {
            if (!esAdministrador)
            {
                return;
            }

            usuarios.Clear();
            usuarios.AddRange(conexion.ObtenerUsuarios());

            personal.Clear();
            personal.AddRange(conexion.ObtenerPersonalItems());

            auditorias.Clear();
            auditorias.AddRange(conexion.ObtenerAuditoriaSesion());

            CargarResumenUsuarios();
            CargarResumenPersonal();
            CargarResumenAuditoria();
        }

        private void CargarResumenUsuarios()
        {
            int activos = usuarios.Count(u => u.Activo);
            int inactivos = usuarios.Count - activos;
            int administradores = usuarios.Count(u => !string.IsNullOrWhiteSpace(u.Perfil) && u.Perfil.IndexOf("Administrador", StringComparison.OrdinalIgnoreCase) >= 0);
            int sinFicha = usuarios.Count(u => u.IdPersonal <= 0);

            lblUsuariosTotal.Text = usuarios.Count.ToString();
            lblUsuariosActivos.Text = activos.ToString();
            lblUsuariosInactivos.Text = inactivos.ToString();
            lblUsuariosAdmin.Text = administradores.ToString();
            lblUsuariosSinFicha.Text = sinFicha.ToString();

            dgvPerfiles.DataSource = null;
            dgvPerfiles.DataSource = usuarios
                .SelectMany(u => TextoOValor(u.Perfil).Split(','))
                .Select(p => p.Trim())
                .Where(p => p.Length > 0 && p != "-")
                .GroupBy(p => p, StringComparer.OrdinalIgnoreCase)
                .OrderByDescending(g => g.Count())
                .Select(g => new
                {
                    Perfil = g.Key,
                    Usuarios = g.Count()
                })
                .ToList();
        }

        private void CargarResumenPersonal()
        {
            int activos = 0;
            int pendientes = 0;
            int sinContacto = 0;
            Dictionary<string, int> porProvincia = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            Dictionary<string, int> porMedio = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (classConexion.PersonalItem item in personal)
            {
                classConexion.PersonalDetalle detalle = conexion.ObtenerPersonalDetalle(item.IdPersonal);
                if (detalle == null)
                {
                    continue;
                }

                if (detalle.Activo)
                {
                    activos++;
                }

                if (!EsFichaCompleta(detalle))
                {
                    pendientes++;
                }

                Sumar(porProvincia, TextoOValor(detalle.Provincia));

                List<classConexion.ContactoItem> contactos = conexion.ObtenerContactosPorPersonal(item.IdPersonal);
                if (contactos.Count == 0)
                {
                    sinContacto++;
                }

                foreach (classConexion.ContactoItem contacto in contactos)
                {
                    Sumar(porMedio, TextoOValor(contacto.Medio));
                }
            }

            lblPersonalTotal.Text = personal.Count.ToString();
            lblPersonalActivo.Text = activos.ToString();
            lblPersonalPendiente.Text = pendientes.ToString();
            lblPersonalSinContacto.Text = sinContacto.ToString();

            dgvProvincias.DataSource = null;
            dgvProvincias.DataSource = porProvincia
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .Select(p => new
                {
                    Provincia = p.Key,
                    Personas = p.Value
                })
                .ToList();

            dgvContactos.DataSource = null;
            dgvContactos.DataSource = porMedio
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .Select(p => new
                {
                    Medio = p.Key,
                    Contactos = p.Value
                })
                .ToList();
        }

        private void CargarResumenAuditoria()
        {
            Dictionary<string, int> acciones = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (classConexion.AuditoriaItem item in auditorias)
            {
                Sumar(acciones, NormalizarDetalleAuditoria(item.Detalle));
            }

            lblAuditoriaTotal.Text = auditorias.Count.ToString();
            lblAuditoriaTipos.Text = acciones.Count.ToString();

            Series serie = chartAuditoria.Series["Acciones"];
            serie.Points.Clear();

            foreach (KeyValuePair<string, int> entrada in acciones.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(8))
            {
                int index = serie.Points.AddXY(entrada.Key, entrada.Value);
                serie.Points[index].AxisLabel = entrada.Key;
            }
        }

        private bool EsFichaCompleta(classConexion.PersonalDetalle detalle)
        {
            return !string.IsNullOrWhiteSpace(detalle.DNI)
                && !string.IsNullOrWhiteSpace(detalle.Apellido)
                && !string.IsNullOrWhiteSpace(detalle.Nombre)
                && !string.IsNullOrWhiteSpace(detalle.Direccion)
                && !string.IsNullOrWhiteSpace(detalle.Localidad)
                && !string.IsNullOrWhiteSpace(detalle.Provincia);
        }

        private void Sumar(Dictionary<string, int> valores, string clave)
        {
            if (!valores.ContainsKey(clave))
            {
                valores[clave] = 0;
            }

            valores[clave]++;
        }

        private string NormalizarDetalleAuditoria(string detalle)
        {
            if (string.IsNullOrWhiteSpace(detalle))
            {
                return "Sin detalle";
            }

            string texto = detalle.Trim();
            int separador = texto.IndexOf(':');
            if (separador > 0)
            {
                return texto.Substring(0, separador).Trim();
            }

            separador = texto.IndexOf(" - ", StringComparison.Ordinal);
            if (separador > 0)
            {
                return texto.Substring(0, separador).Trim();
            }

            return texto;
        }

        private string TextoOValor(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? "-" : valor;
        }

        private void AplicarEstiloGrid(DataGridView grid)
        {
            if (grid == null)
            {
                return;
            }

            grid.AllowUserToResizeRows = false;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Color.FromArgb(255, 250, 243);
            grid.GridColor = Color.FromArgb(232, 218, 198);
            grid.ColumnHeadersHeight = 34;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(111, 74, 45);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(111, 74, 45);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 243);
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(72, 48, 34);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 198, 174);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(72, 48, 34);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 243, 235);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(72, 48, 34);
            grid.RowTemplate.Height = 28;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BloquearSinPermiso()
        {
            pnlContenido.Visible = false;
            btnActualizar.Enabled = false;
            lblTitulo.Text = "Acceso restringido";
            lblSubtitulo.Text = "Solo los administradores pueden ver reportes.";
        }
    }
}
