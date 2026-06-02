using System;
using System.Drawing;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmUsuarioPerfil : Form
    {
        private readonly int idUsuario;
        private readonly string usuario;
        private readonly string mail;
        private readonly string perfil;
        private readonly int idPersonal;
        private readonly classConexion conexion = new classConexion();

        public frmUsuarioPerfil() : this(0, "", "", "", 0)
        {
        }

        public frmUsuarioPerfil(int idUsuario) : this(idUsuario, "", "", "", 0)
        {
        }

        public frmUsuarioPerfil(int idUsuario, string usuario, string mail, string perfil, int idPersonal)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.mail = mail;
            this.perfil = perfil;
            this.idPersonal = idPersonal;
            CrearCardDatosCuenta();

            if (idUsuario == 0)
            {
                MessageBox.Show("No se pudo identificar el usuario actual.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpCambio.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpiarCambio.Enabled = false;
            }
        }

        private void CrearCardDatosCuenta()
        {
            Guna.UI2.WinForms.Guna2Panel grpCuenta = new Guna.UI2.WinForms.Guna2Panel();
            grpCuenta.BorderColor = Color.FromArgb(218, 198, 174);
            grpCuenta.BorderRadius = 16;
            grpCuenta.BorderThickness = 1;
            grpCuenta.FillColor = Color.FromArgb(246, 238, 226);
            grpCuenta.Location = new Point(402, 120);
            grpCuenta.Name = "grpCuenta";
            grpCuenta.Size = new Size(330, 210);
            grpCuenta.ShadowDecoration.Color = Color.FromArgb(120, 92, 64);
            grpCuenta.ShadowDecoration.Depth = 8;
            grpCuenta.ShadowDecoration.Enabled = true;

            grpCuenta.Controls.Add(CrearLabel("Datos de cuenta", 22, 18, true));
            grpCuenta.Controls.Add(CrearLabel("Usuario: " + TextoOValor(usuario), 26, 60, false));
            grpCuenta.Controls.Add(CrearLabel("Mail: " + TextoOValor(mail), 26, 92, false));
            grpCuenta.Controls.Add(CrearLabel("Perfil: " + TextoOValor(perfil), 26, 124, false));
            grpCuenta.Controls.Add(CrearLabel("Ficha personal: " + (idPersonal > 0 ? "Asociada" : "Pendiente"), 26, 156, false));
            Controls.Add(grpCuenta);
        }

        private Label CrearLabel(string texto, int x, int y, bool titulo)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Text = texto;
            label.Location = new Point(x, y);
            label.Size = new Size(278, 24);
            label.Font = titulo
                ? new Font("Segoe UI Semibold", 12F, FontStyle.Bold)
                : new Font("Segoe UI", 9.5F);
            label.ForeColor = titulo ? Color.FromArgb(72, 48, 34) : Color.FromArgb(84, 60, 42);
            return label;
        }

        private string TextoOValor(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? "-" : valor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje;
            bool actualizado = conexion.CambiarContrasena(
                idUsuario,
                txtActual.Text,
                txtNueva.Text,
                out mensaje);

            MessageBox.Show(
                mensaje,
                "Mi cuenta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (actualizado)
            {
                LimpiarCampos();
            }
        }

        private void btnLimpiarCambio_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void chkMostrarContrasenas_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = chkMostrarContrasenas.Checked ? '\0' : '*';
            txtActual.PasswordChar = passwordChar;
            txtNueva.PasswordChar = passwordChar;
            txtConfirmar.PasswordChar = passwordChar;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtActual.Text))
            {
                MessageBox.Show("Ingrese la contrasena actual.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtActual.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNueva.Text))
            {
                MessageBox.Show("Ingrese la nueva contrasena.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNueva.Focus();
                return false;
            }

            if (txtNueva.Text != txtConfirmar.Text)
            {
                MessageBox.Show("La nueva contrasena y la confirmacion no coinciden.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmar.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtActual.Clear();
            txtNueva.Clear();
            txtConfirmar.Clear();
            txtActual.Focus();
        }
    }
}
