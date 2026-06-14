using pryBazanERP.Conexión;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace pryBazanERP.Formulario
{
    public partial class frmEstadoUsuarios : Form
    {
        private classConexion conexion;
        private readonly int idUsuarioActual;
        private readonly string usuarioAdministrador;
        private readonly bool esAdministrador;
        private List<classConexion.UsuarioItem> usuarios = new List<classConexion.UsuarioItem>();

        public frmEstadoUsuarios() : this(0, "", false)
        {
        }

        public frmEstadoUsuarios(int idUsuarioActual, string usuarioAdministrador, bool esAdministrador)
        {
            this.idUsuarioActual = idUsuarioActual;
            this.usuarioAdministrador = usuarioAdministrador;
            this.esAdministrador = esAdministrador;
            InitializeComponent();

            if (EnModoDiseno())
            {
                return;
            }

            conexion = new classConexion();
            AppIcon.Aplicar(this);

            if (!this.esAdministrador)
            {
                BloquearSinPermiso();
                return;
            }

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (conexion == null)
            {
                return;
            }

            try
            {
                usuarios = conexion.ObtenerUsuarios();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarios;
                lblResumen.Text = "Usuarios registrados: " + usuarios.Count;
                OcultarColumnasQueNoVan();
                PintarUsuariosInactivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios: " + ex.Message, "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            classConexion.UsuarioItem usuario = ObtenerUsuarioSeleccionado();

            if (usuario == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuario.Activo)
            {
                MessageBox.Show("El usuario seleccionado ya esta activo.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CambiarEstadoUsuario(usuario, true);
        }

        private void btnInactivarUsuario_Click(object sender, EventArgs e)
        {
            classConexion.UsuarioItem usuario = ObtenerUsuarioSeleccionado();

            if (usuario == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!usuario.Activo)
            {
                MessageBox.Show("El usuario seleccionado ya esta inactivo.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuario.IdUsuario == idUsuarioActual)
            {
                MessageBox.Show("No podes inactivar tu propio usuario.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CambiarEstadoUsuario(usuario, false);
        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            OcultarColumnasQueNoVan();
            PintarUsuariosInactivos();
        }

        private void CambiarEstadoUsuario(classConexion.UsuarioItem usuario, bool nuevoEstado)
        {
            string mensaje;
            bool actualizado = conexion.ActualizarEstadoUsuario(usuario.IdUsuario, nuevoEstado, out mensaje);
            MessageBox.Show(mensaje, "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (actualizado)
            {
                conexion.GrabarAuditoriaSesion(TextoAuditoria(), (nuevoEstado ? "Activo usuario: " : "Inactivo usuario: ") + usuario.Mail);
                CargarUsuarios();
            }
        }

        private classConexion.UsuarioItem ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios == null || dgvUsuarios.CurrentRow == null)
            {
                return null;
            }

            return dgvUsuarios.CurrentRow.DataBoundItem as classConexion.UsuarioItem;
        }

        private void OcultarColumnasQueNoVan()
        {
            if (dgvUsuarios.Columns.Contains("IdUsuario"))
            {
                dgvUsuarios.Columns["IdUsuario"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("IdPersonal"))
            {
                dgvUsuarios.Columns["IdPersonal"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("Activo"))
            {
                dgvUsuarios.Columns["Activo"].Visible = false;
            }

            if (dgvUsuarios.Columns.Contains("NombreCompleto"))
            {
                dgvUsuarios.Columns["NombreCompleto"].Visible = false;
            }
        }

        private void PintarUsuariosInactivos()
        {
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                classConexion.UsuarioItem usuario = fila.DataBoundItem as classConexion.UsuarioItem;

                if (usuario != null && !usuario.Activo)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.ForeColor = Color.White;
                    fila.DefaultCellStyle.SelectionBackColor = Color.Red;
                    fila.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void BloquearSinPermiso()
        {
            Controls.Clear();
            Controls.Add(CrearTitulo("Acceso restringido", 34, 26, 24F));
            Controls.Add(CrearTexto("Solo los administradores pueden gestionar usuarios.", 39, 82, 10F, 560, 24));
        }

        private Label CrearTitulo(string texto, int x, int y, float size)
        {
            Label label = CrearTexto(texto, x, y, size, 520, 46);
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", size, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(72, 48, 34);
            return label;
        }

        private Label CrearTexto(string texto, int x, int y, float size, int ancho, int alto)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Text = texto;
            label.Location = new Point(x, y);
            label.Size = new Size(ancho, alto);
            label.Font = new Font("Segoe UI", size);
            label.ForeColor = Color.FromArgb(120, 92, 64);
            return label;
        }

        private string TextoAuditoria()
        {
            return string.IsNullOrWhiteSpace(usuarioAdministrador) ? "Administrador" : usuarioAdministrador;
        }

        private static bool EnModoDiseno()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }
    }
}
