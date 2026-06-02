using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmContacto : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly int idPersonal;
        private readonly string nombrePersona;

        public frmContacto() : this(0, "")
        {
        }

        public frmContacto(int idPersonal, string nombrePersona)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.idPersonal = idPersonal;
            this.nombrePersona = nombrePersona;
            InicializarCombos();
            CargarPantalla();
        }

        private void InicializarCombos()
        {
            cmbMedio.Items.Clear();
            cmbMedio.Items.Add("Mail");
            cmbMedio.Items.Add("Telefono");
            cmbMedio.SelectedIndex = 0;

            cmbUso.Items.Clear();
            cmbUso.Items.Add("Principal");
            cmbUso.Items.Add("Auxilio");
            cmbUso.SelectedIndex = 0;
        }

        private void CargarPantalla()
        {
            lblPersonaValor.Text = string.IsNullOrWhiteSpace(nombrePersona) ? "Sin personal asociado" : nombrePersona;

            if (idPersonal == 0)
            {
                MessageBox.Show("El usuario actual no tiene un personal asociado. No se pueden cargar contactos.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpCarga.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpiarCarga.Enabled = false;
                dgvContactos.DataSource = null;
                return;
            }

            CargarContactos();
        }

        private void CargarContactos()
        {
            try
            {
                List<classConexion.ContactoItem> contactos = conexion.ObtenerContactosPorPersonal(idPersonal);
                dgvContactos.DataSource = contactos;

                if (dgvContactos.Columns["IdContacto"] != null)
                {
                    dgvContactos.Columns["IdContacto"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los contactos: " + ex.Message, "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                idPersonal,
                cmbMedio.Text,
                cmbUso.Text,
                txtDato.Text.Trim(),
                out mensaje);

            MessageBox.Show(
                mensaje,
                "Contacto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (guardado)
            {
                LimpiarCampos();
                CargarContactos();
            }
        }

        private void btnLimpiarCarga_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbMedio.Text))
            {
                MessageBox.Show("Seleccione el medio de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMedio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUso.Text))
            {
                MessageBox.Show("Seleccione si el contacto es principal o de auxilio.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUso.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("Ingrese el dato de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDato.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            cmbMedio.SelectedIndex = 0;
            cmbUso.SelectedIndex = 0;
            txtDato.Clear();
            txtDato.Focus();
        }
    }
}
