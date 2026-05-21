using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmContacto : Form
    {
        private readonly classConexion conexion = new classConexion();

        public frmContacto()
        {
            InitializeComponent();
            CargarPersonal();
        }

        private void CargarPersonal()
        {
            try
            {
                List<classConexion.PersonalItem> personal = conexion.ObtenerPersonalItems();

                cmbPersonal.DataSource = personal;
                cmbPersonal.DisplayMember = "Descripcion";
                cmbPersonal.ValueMember = "DNI";
                cmbPersonal.SelectedIndex = personal.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el personal: " + ex.Message, "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje;
            bool guardado = conexion.GuardarContacto(
                cmbPersonal.SelectedValue.ToString(),
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (cmbPersonal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un personal.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPersonal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMail.Text) &&
                string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                string.IsNullOrWhiteSpace(txtInstagram.Text) &&
                string.IsNullOrWhiteSpace(txtFacebook.Text) &&
                string.IsNullOrWhiteSpace(txtTwitter.Text))
            {
                MessageBox.Show("Ingrese al menos un dato de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtMail.Clear();
            txtTelefono.Clear();
            txtInstagram.Clear();
            txtFacebook.Clear();
            txtTwitter.Clear();
            chkActivo.Checked = true;

            if (cmbPersonal.Items.Count > 0)
            {
                cmbPersonal.SelectedIndex = 0;
            }

            cmbPersonal.Focus();
        }
    }
}
