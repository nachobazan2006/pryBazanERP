using System;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmUsuarioPerfil : Form
    {
        private readonly int idUsuario;
        private readonly classConexion conexion = new classConexion();

        public frmUsuarioPerfil() : this(0)
        {
        }

        public frmUsuarioPerfil(int idUsuario)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.idUsuario = idUsuario;

            if (idUsuario == 0)
            {
                MessageBox.Show("No se pudo identificar el usuario actual.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpCambio.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpiarCambio.Enabled = false;
            }
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
