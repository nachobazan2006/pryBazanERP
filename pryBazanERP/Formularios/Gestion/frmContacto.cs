using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            classConexion conexion = new classConexion();
            string mensaje;

            bool guardado = conexion.GuardarContacto(
                txtPersonal.Text.Trim(),
                txtMail.Text.Trim(),
                txtTelefono.Text.Trim(),
                chkActivo.Checked,
                txtInstagram.Text.Trim(),
                txtFacebook.Text.Trim(),
                txtTwitter.Text.Trim(),
                out mensaje);

            MessageBox.Show(
                mensaje,
                "Contacto",
                MessageBoxButtons.OK,
                guardado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (guardado)
            {
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPersonal.Text))
            {
                MessageBox.Show("Ingresá el DNI del personal.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPersonal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMail.Text) &&
                string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                string.IsNullOrWhiteSpace(txtInstagram.Text) &&
                string.IsNullOrWhiteSpace(txtFacebook.Text) &&
                string.IsNullOrWhiteSpace(txtTwitter.Text))
            {
                MessageBox.Show("Ingresá al menos un dato de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtPersonal.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            txtInstagram.Clear();
            txtFacebook.Clear();
            txtTwitter.Clear();
            chkActivo.Checked = true;
            txtPersonal.Focus();
        }
    }
}
