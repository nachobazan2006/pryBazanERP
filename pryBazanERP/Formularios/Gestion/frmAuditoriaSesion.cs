using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public class frmAuditoriaSesion : Form
    {
        private class FiltroItem
        {
            public string Texto { get; set; }
            public string Valor { get; set; }

            public override string ToString()
            {
                return Texto;
            }
        }

        private readonly classConexion conexion = new classConexion();
        private List<classConexion.AuditoriaItem> auditorias = new List<classConexion.AuditoriaItem>();
        private DataGridView dgvAuditoria;
        private Label lblResumen;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDetalle;
        private DateTimePicker dtpDia;

        public frmAuditoriaSesion()
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            CargarAuditoria();
        }

        private void InitializeComponent()
        {
            BackColor = Color.FromArgb(232, 218, 198);
            ClientSize = new Size(800, 580);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bazan ERP - Auditoria";

            Label lblTitulo = CrearTitulo("Auditoria", 34, 26, 24F);
            Label lblSubtitulo = CrearTexto("Movimientos de sesion y operaciones registradas", 39, 74, 10F);
            Guna.UI2.WinForms.Guna2Button btnActualizar = CrearBotonPrincipal("Actualizar", 610, 42, 126, 38);
            btnActualizar.Click += btnActualizar_Click;

            Guna.UI2.WinForms.Guna2Panel grpListado = new Guna.UI2.WinForms.Guna2Panel();
            grpListado.BorderColor = Color.FromArgb(218, 198, 174);
            grpListado.BorderRadius = 16;
            grpListado.BorderThickness = 1;
            grpListado.FillColor = Color.FromArgb(246, 238, 226);
            grpListado.Location = new Point(40, 118);
            grpListado.Size = new Size(696, 424);
            grpListado.ShadowDecoration.Color = Color.FromArgb(120, 92, 64);
            grpListado.ShadowDecoration.Depth = 8;
            grpListado.ShadowDecoration.Enabled = true;

            lblResumen = CrearTexto("Movimientos registrados", 22, 18, 10F);
            lblResumen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblResumen.ForeColor = Color.FromArgb(84, 60, 42);

            Guna.UI2.WinForms.Guna2Panel grpFiltros = CrearPanelFiltros();

            dgvAuditoria = new DataGridView();
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.AllowUserToDeleteRows = false;
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditoria.BackgroundColor = Color.FromArgb(255, 250, 243);
            dgvAuditoria.BorderStyle = BorderStyle.FixedSingle;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(22, 108);
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.RowHeadersVisible = false;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.Size = new Size(652, 294);

            grpListado.Controls.Add(lblResumen);
            grpListado.Controls.Add(grpFiltros);
            grpListado.Controls.Add(dgvAuditoria);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnActualizar);
            Controls.Add(grpListado);
        }

        private Guna.UI2.WinForms.Guna2Panel CrearPanelFiltros()
        {
            Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel();
            panel.BorderColor = Color.FromArgb(218, 198, 174);
            panel.BorderRadius = 10;
            panel.BorderThickness = 1;
            panel.FillColor = Color.FromArgb(255, 250, 243);
            panel.Location = new Point(22, 46);
            panel.Size = new Size(652, 48);

            cmbUsuario = CrearCombo(12, 10, 168);
            cmbUsuario.SelectedIndexChanged += filtro_Changed;

            cmbPerfil = CrearCombo(188, 10, 118);
            cmbPerfil.SelectedIndexChanged += filtro_Changed;

            dtpDia = new DateTimePicker();
            dtpDia.Format = DateTimePickerFormat.Short;
            dtpDia.Location = new Point(314, 14);
            dtpDia.Size = new Size(96, 23);
            dtpDia.Value = DateTime.Today;
            dtpDia.ValueChanged += filtro_Changed;

            cmbDetalle = CrearCombo(420, 10, 124);
            cmbDetalle.SelectedIndexChanged += filtro_Changed;

            Guna.UI2.WinForms.Guna2Button btnRestablecer = CrearBotonSecundario("Restablecer", 558, 10, 82, 32);
            btnRestablecer.Click += btnRestablecerFiltros_Click;

            panel.Controls.Add(cmbUsuario);
            panel.Controls.Add(cmbPerfil);
            panel.Controls.Add(dtpDia);
            panel.Controls.Add(cmbDetalle);
            panel.Controls.Add(btnRestablecer);
            return panel;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarAuditoria();
        }

        private void CargarAuditoria()
        {
            try
            {
                if (dgvAuditoria == null || lblResumen == null)
                {
                    return;
                }

                auditorias = conexion.ObtenerAuditoriaSesion();
                CargarCombosFiltro();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la auditoria: " + ex.Message, "Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarCombosFiltro()
        {
            string usuarioSeleccionado = ObtenerSeleccion(cmbUsuario);
            string perfilSeleccionado = ObtenerSeleccion(cmbPerfil);
            string detalleSeleccionado = ObtenerSeleccion(cmbDetalle);

            List<FiltroItem> usuarios = auditorias
                .Where(a => !string.IsNullOrWhiteSpace(a.Usuario))
                .Select(a => new FiltroItem
                {
                    Texto = FormatearUsuarioAuditoria(a.Usuario),
                    Valor = a.Usuario.Trim()
                })
                .GroupBy(i => i.Valor, StringComparer.OrdinalIgnoreCase)
                .Select(g => g.First())
                .OrderBy(i => i.Texto)
                .ToList();

            List<string> perfiles = auditorias
                .Where(a => !string.IsNullOrWhiteSpace(a.Perfil))
                .SelectMany(a => a.Perfil.Split(','))
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(p => p)
                .ToList();

            List<string> detalles = auditorias
                .Where(a => !string.IsNullOrWhiteSpace(a.Detalle))
                .Select(a => a.Detalle.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(d => d)
                .ToList();

            CargarComboUsuarios(cmbUsuario, usuarios, usuarioSeleccionado);
            CargarCombo(cmbPerfil, perfiles, perfilSeleccionado);
            CargarCombo(cmbDetalle, detalles, detalleSeleccionado);
        }

        private void CargarComboUsuarios(Guna.UI2.WinForms.Guna2ComboBox combo, List<FiltroItem> valores, string seleccionado)
        {
            combo.SelectedIndexChanged -= filtro_Changed;
            combo.Items.Clear();
            combo.Items.Add(new FiltroItem { Texto = "Todos", Valor = "Todos" });

            foreach (FiltroItem valor in valores)
            {
                combo.Items.Add(valor);
            }

            FiltroItem itemSeleccionado = combo.Items.Cast<object>()
                .OfType<FiltroItem>()
                .FirstOrDefault(i => i.Valor.Equals(seleccionado, StringComparison.OrdinalIgnoreCase));

            combo.SelectedItem = itemSeleccionado ?? combo.Items[0];
            combo.SelectedIndexChanged += filtro_Changed;
        }

        private void CargarCombo(Guna.UI2.WinForms.Guna2ComboBox combo, List<string> valores, string seleccionado)
        {
            combo.SelectedIndexChanged -= filtro_Changed;
            combo.Items.Clear();
            combo.Items.Add("Todos");

            foreach (string valor in valores)
            {
                combo.Items.Add(valor);
            }

            combo.SelectedItem = combo.Items.Contains(seleccionado) ? seleccionado : "Todos";
            combo.SelectedIndexChanged += filtro_Changed;
        }

        private void AplicarFiltros()
        {
            if (dgvAuditoria == null || lblResumen == null)
            {
                return;
            }

            IEnumerable<classConexion.AuditoriaItem> filtradas = auditorias;
            string usuario = ObtenerSeleccion(cmbUsuario);
            string perfil = ObtenerSeleccion(cmbPerfil);
            string detalle = ObtenerSeleccion(cmbDetalle);
            DateTime dia = dtpDia.Value.Date;

            filtradas = filtradas.Where(a => a.Fecha.Date == dia);

            if (usuario != "Todos")
            {
                filtradas = filtradas.Where(a => a.Usuario != null && a.Usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase));
            }

            if (perfil != "Todos")
            {
                filtradas = filtradas.Where(a => a.Perfil != null && a.Perfil.IndexOf(perfil, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (detalle != "Todos")
            {
                filtradas = filtradas.Where(a => a.Detalle != null && a.Detalle.Equals(detalle, StringComparison.OrdinalIgnoreCase));
            }

            List<classConexion.AuditoriaItem> resultado = filtradas.ToList();
            dgvAuditoria.DataSource = resultado;
            lblResumen.Text = "Movimientos registrados: " + resultado.Count.ToString();

            ConfigurarColumna("IdAuditoria", "Id", "");
            ConfigurarColumna("Fecha", "Fecha", "dd/MM/yyyy");
            ConfigurarColumna("Hora", "Hora", "");
            ConfigurarColumna("Usuario", "Usuario", "");
            ConfigurarColumna("Perfil", "Perfil", "");
            ConfigurarColumna("Detalle", "Detalle", "");
        }

        private string ObtenerSeleccion(Guna.UI2.WinForms.Guna2ComboBox combo)
        {
            if (combo == null || combo.SelectedItem == null)
            {
                return "Todos";
            }

            FiltroItem item = combo.SelectedItem as FiltroItem;
            if (item != null)
            {
                return item.Valor;
            }

            return combo.SelectedItem.ToString();
        }

        private void filtro_Changed(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnRestablecerFiltros_Click(object sender, EventArgs e)
        {
            dtpDia.Value = DateTime.Today;
            cmbUsuario.SelectedItem = cmbUsuario.Items[0];
            cmbPerfil.SelectedItem = "Todos";
            cmbDetalle.SelectedItem = "Todos";
            AplicarFiltros();
        }

        private string ObtenerNombreUsuario(string mail)
        {
            string nombre = conexion.ObtenerNombreCompletoUsuarioPorMail(mail);
            return string.IsNullOrWhiteSpace(nombre) ? mail : nombre;
        }

        private string FormatearUsuarioAuditoria(string mail)
        {
            string nombre = ObtenerNombreUsuario(mail);
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return mail;
            }

            if (nombre.Equals(mail, StringComparison.OrdinalIgnoreCase))
            {
                return mail;
            }

            return nombre + " (" + mail + ")";
        }

        private void ConfigurarColumna(string nombre, string titulo, string formato)
        {
            if (dgvAuditoria == null || dgvAuditoria.Columns == null || !dgvAuditoria.Columns.Contains(nombre))
            {
                return;
            }

            DataGridViewColumn columna = dgvAuditoria.Columns[nombre];

            if (columna == null)
            {
                return;
            }

            columna.HeaderText = titulo;

            if (!string.IsNullOrWhiteSpace(formato) && columna.DefaultCellStyle != null)
            {
                columna.DefaultCellStyle.Format = formato;
            }
        }

        private Guna.UI2.WinForms.Guna2ComboBox CrearCombo(int x, int y, int ancho)
        {
            Guna.UI2.WinForms.Guna2ComboBox combo = new Guna.UI2.WinForms.Guna2ComboBox();
            combo.BackColor = Color.Transparent;
            combo.BorderColor = Color.FromArgb(218, 198, 174);
            combo.BorderRadius = 8;
            combo.DrawMode = DrawMode.OwnerDrawFixed;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FillColor = Color.FromArgb(255, 250, 243);
            combo.Font = new Font("Segoe UI", 9F);
            combo.ForeColor = Color.FromArgb(72, 48, 34);
            combo.ItemHeight = 26;
            combo.Location = new Point(x, y);
            combo.Size = new Size(ancho, 32);
            return combo;
        }

        private Label CrearTitulo(string texto, int x, int y, float tamano)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", tamano, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(72, 48, 34);
            label.Location = new Point(x, y);
            label.Text = texto;
            return label;
        }

        private Label CrearTexto(string texto, int x, int y, float tamano)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", tamano);
            label.ForeColor = Color.FromArgb(120, 92, 64);
            label.Location = new Point(x, y);
            label.Text = texto;
            return label;
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonPrincipal(string texto, int x, int y, int ancho, int alto)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderRadius = 12;
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(111, 74, 45);
            boton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            boton.ForeColor = Color.White;
            boton.HoverState.FillColor = Color.FromArgb(84, 60, 42);
            boton.Location = new Point(x, y);
            boton.Size = new Size(ancho, alto);
            boton.Text = texto;
            return boton;
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonSecundario(string texto, int x, int y, int ancho, int alto)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderColor = Color.FromArgb(150, 111, 76);
            boton.BorderRadius = 8;
            boton.BorderThickness = 1;
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(255, 250, 243);
            boton.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            boton.ForeColor = Color.FromArgb(84, 60, 42);
            boton.HoverState.FillColor = Color.FromArgb(218, 198, 174);
            boton.Location = new Point(x, y);
            boton.Size = new Size(ancho, alto);
            boton.Text = texto;
            return boton;
        }
    }
}
