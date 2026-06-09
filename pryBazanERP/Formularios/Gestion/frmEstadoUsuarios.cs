using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public class frmEstadoUsuarios : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly int idUsuarioActual;
        private readonly string usuarioAdministrador;
        private readonly bool esAdministrador;
        private List<classConexion.UsuarioItem> usuarios = new List<classConexion.UsuarioItem>();
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsuarios;
        private Label lblResumen;
        private Guna.UI2.WinForms.Guna2Button btnCambiarEstado;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;

        public frmEstadoUsuarios() : this(0, "", false)
        {
        }

        public frmEstadoUsuarios(int idUsuarioActual, string usuarioAdministrador, bool esAdministrador)
        {
            this.idUsuarioActual = idUsuarioActual;
            this.usuarioAdministrador = usuarioAdministrador;
            this.esAdministrador = esAdministrador;
            InitializeComponent();
            AppIcon.Aplicar(this);

            if (!this.esAdministrador)
            {
                BloquearSinPermiso();
                return;
            }

            CargarUsuarios();
        }

        private void InitializeComponent()
        {
            BackColor = Color.FromArgb(232, 218, 198);
            ClientSize = new Size(800, 580);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bazan ERP - Estado de usuarios";

            Label lblTitulo = CrearTitulo("Estado de usuarios", 34, 26, 24F);
            Label lblSubtitulo = CrearTexto("Administracion de accesos activos e inactivos", 39, 74, 10F, 520, 24);

            btnActualizar = CrearBotonPrincipal("Actualizar", 474, 42, 118, 38);
            btnActualizar.Click += btnActualizar_Click;

            btnCambiarEstado = CrearBotonPrincipal("Cambiar estado", 606, 42, 130, 38);
            btnCambiarEstado.Click += btnCambiarEstado_Click;

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

            lblResumen = CrearTexto("Usuarios registrados", 22, 18, 10F, 420, 24);
            lblResumen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblResumen.ForeColor = Color.FromArgb(84, 60, 42);

            dgvUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(255, 250, 243);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(22, 54);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(652, 348);
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 250, 243);
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(72, 48, 34);
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(218, 198, 174);
            dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(72, 48, 34);
            dgvUsuarios.ThemeStyle.BackColor = Color.FromArgb(255, 250, 243);
            dgvUsuarios.ThemeStyle.GridColor = Color.FromArgb(232, 218, 198);
            dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(111, 74, 45);
            dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 250, 243);
            dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(72, 48, 34);
            dgvUsuarios.ThemeStyle.RowsStyle.Height = 28;
            dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(218, 198, 174);
            dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(72, 48, 34);

            AgregarColumna("NombreCompleto", "Usuario", 180);
            AgregarColumna("Mail", "Mail", 190);
            AgregarColumna("Perfil", "Perfil", 140);
            AgregarColumna("Estado", "Estado", 90);

            grpListado.Controls.Add(lblResumen);
            grpListado.Controls.Add(dgvUsuarios);

            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnActualizar);
            Controls.Add(btnCambiarEstado);
            Controls.Add(grpListado);
        }

        private void CargarUsuarios()
        {
            try
            {
                usuarios = conexion.ObtenerUsuarios();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarios;
                lblResumen.Text = "Usuarios registrados: " + usuarios.Count;
                ActualizarBotonEstado();
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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            classConexion.UsuarioItem usuario = ObtenerUsuarioSeleccionado();

            if (usuario == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool nuevoEstado = !usuario.Activo;

            if (usuario.IdUsuario == idUsuarioActual && !nuevoEstado)
            {
                MessageBox.Show("No podes inactivar tu propio usuario.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje;
            bool actualizado = conexion.ActualizarEstadoUsuario(usuario.IdUsuario, nuevoEstado, out mensaje);
            MessageBox.Show(mensaje, "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (actualizado)
            {
                conexion.GrabarAuditoriaSesion(TextoAuditoria(), (nuevoEstado ? "Activo usuario: " : "Inactivo usuario: ") + usuario.Mail);
                CargarUsuarios();
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotonEstado();
        }

        private void ActualizarBotonEstado()
        {
            classConexion.UsuarioItem usuario = ObtenerUsuarioSeleccionado();
            btnCambiarEstado.Enabled = usuario != null;
            btnCambiarEstado.Text = usuario != null && usuario.Activo ? "Inactivar" : "Activar";
        }

        private classConexion.UsuarioItem ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios == null || dgvUsuarios.CurrentRow == null)
            {
                return null;
            }

            return dgvUsuarios.CurrentRow.DataBoundItem as classConexion.UsuarioItem;
        }

        private void AgregarColumna(string propiedad, string titulo, int ancho)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.DataPropertyName = propiedad;
            columna.HeaderText = titulo;
            columna.Name = propiedad;
            columna.FillWeight = ancho;
            dgvUsuarios.Columns.Add(columna);
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonPrincipal(string texto, int x, int y, int ancho, int alto)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderRadius = 12;
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(111, 74, 45);
            boton.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            boton.ForeColor = Color.White;
            boton.HoverState.FillColor = Color.FromArgb(84, 60, 42);
            boton.Location = new Point(x, y);
            boton.Size = new Size(ancho, alto);
            boton.Text = texto;
            return boton;
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

        private void BloquearSinPermiso()
        {
            Controls.Clear();
            Controls.Add(CrearTitulo("Acceso restringido", 34, 26, 24F));
            Controls.Add(CrearTexto("Solo los administradores pueden gestionar usuarios.", 39, 82, 10F, 560, 24));
        }

        private string TextoAuditoria()
        {
            return string.IsNullOrWhiteSpace(usuarioAdministrador) ? "Administrador" : usuarioAdministrador;
        }
    }
}
