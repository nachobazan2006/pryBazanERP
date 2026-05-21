using System.Windows.Forms;
using pryBazanERP.Acceso_datos;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmPersonal : Form
    {
        private readonly LocalidadesAPI localidadesAPI = new LocalidadesAPI();
        private readonly Timer temporizadorBusquedaLocalidad = new Timer();

        public frmPersonal()
        {
            InitializeComponent();
            temporizadorBusquedaLocalidad.Interval = 450;
            temporizadorBusquedaLocalidad.Tick += temporizadorBusquedaLocalidad_Tick;
            cboProvincia.SelectedIndex = 0;
        }

        private void txtLocalidad_TextChanged(object sender, System.EventArgs e)
        {
            temporizadorBusquedaLocalidad.Stop();
            lstLocalidades.Visible = false;

            if (ProvinciaSeleccionadaEsCordoba() && txtLocalidad.Text.Trim().Length >= 2)
            {
                temporizadorBusquedaLocalidad.Start();
            }
        }

        private async void temporizadorBusquedaLocalidad_Tick(object sender, System.EventArgs e)
        {
            temporizadorBusquedaLocalidad.Stop();

            try
            {
                string textoBuscado = txtLocalidad.Text;

                if (textoBuscado.Trim().Length < 2)
                {
                    lstLocalidades.Visible = false;
                    return;
                }

                System.Collections.Generic.List<string> localidades = await localidadesAPI.BuscarLocalidadesCordobaAsync(textoBuscado);

                if (txtLocalidad.Text != textoBuscado)
                {
                    return;
                }

                lstLocalidades.Items.Clear();

                foreach (string localidad in localidades)
                {
                    lstLocalidades.Items.Add(localidad);
                }

                lstLocalidades.Visible = lstLocalidades.Items.Count > 0;
            }
            catch
            {
                lstLocalidades.Visible = false;
            }
        }

        private void lstLocalidades_Click(object sender, System.EventArgs e)
        {
            SeleccionarLocalidad();
        }

        private void lstLocalidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarLocalidad();
                e.Handled = true;
            }
        }

        private void SeleccionarLocalidad()
        {
            if (lstLocalidades.SelectedItem == null)
            {
                return;
            }

            txtLocalidad.Text = lstLocalidades.SelectedItem.ToString();
            txtLocalidad.SelectionStart = txtLocalidad.Text.Length;
            lstLocalidades.Visible = false;
            txtLocalidad.Focus();
        }

        private void cboProvincia_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            bool esCordoba = ProvinciaSeleccionadaEsCordoba();
            txtLocalidad.Enabled = esCordoba;
            lstLocalidades.Visible = false;

            if (!esCordoba)
            {
                txtLocalidad.Clear();
            }
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            classConexion conexion = new classConexion();
            string mensaje;

            bool guardado = conexion.GuardarPersonal(
                txtDni.Text.Trim(),
                txtApellido.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtGeo.Text.Trim(),
                txtLocalidad.Text.Trim(),
                cboProvincia.Text,
                chkActivo.Checked,
                out mensaje);

            MessageBox.Show(
                mensaje,
                "Personal",
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
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingresá el DNI.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingresá el apellido.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresá el nombre.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboProvincia.Text))
            {
                MessageBox.Show("Seleccioná una provincia.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProvincia.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtGeo.Clear();
            txtLocalidad.Clear();
            cboProvincia.SelectedIndex = 0;
            chkActivo.Checked = true;
            lstLocalidades.Visible = false;
            txtDni.Focus();
        }

        private bool ProvinciaSeleccionadaEsCordoba()
        {
            return cboProvincia.Text == "Cordoba";
        }
    }
}
