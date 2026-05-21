using System.Windows.Forms;
using pryBazanERP.Acceso_datos;
using pryBazanERP.Conexión;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pryBazanERP.Formulario
{
    public partial class frmPersonal : Form
    {
        private readonly LocalidadesAPI localidadesAPI = new LocalidadesAPI();
        private readonly Timer temporizadorBusquedaLocalidad = new Timer();
        private readonly List<string> provinciasDisponibles = new List<string>
        {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Ciudad Autonoma de Buenos Aires",
            "Cordoba",
            "Corrientes",
            "Entre Rios",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquen",
            "Rio Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucuman"
        };
        private bool seleccionandoProvincia;

        public frmPersonal()
        {
            InitializeComponent();
            temporizadorBusquedaLocalidad.Interval = 450;
            temporizadorBusquedaLocalidad.Tick += temporizadorBusquedaLocalidad_Tick;
            txtProvincia.Text = "Cordoba";
            ActualizarEstadoLocalidad();
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

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            if (!seleccionandoProvincia)
            {
                MostrarProvinciasFiltradas();
            }

            ActualizarEstadoLocalidad();
        }

        private void txtProvincia_Enter(object sender, EventArgs e)
        {
            MostrarProvinciasFiltradas();
        }

        private void lstProvincias_Click(object sender, EventArgs e)
        {
            SeleccionarProvincia();
        }

        private void lstProvincias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProvincia();
                e.Handled = true;
            }
        }

        private void MostrarProvinciasFiltradas()
        {
            string texto = txtProvincia.Text.Trim();
            IEnumerable<string> provinciasFiltradas = string.IsNullOrWhiteSpace(texto)
                ? provinciasDisponibles
                : provinciasDisponibles.Where(p => p.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0);

            lstProvincias.Items.Clear();

            foreach (string provincia in provinciasFiltradas)
            {
                lstProvincias.Items.Add(provincia);
            }

            lstProvincias.Visible = lstProvincias.Items.Count > 0;
            lstProvincias.BringToFront();
        }

        private void SeleccionarProvincia()
        {
            if (lstProvincias.SelectedItem == null)
            {
                return;
            }

            seleccionandoProvincia = true;
            txtProvincia.Text = lstProvincias.SelectedItem.ToString();
            txtProvincia.SelectionStart = txtProvincia.Text.Length;
            seleccionandoProvincia = false;

            lstProvincias.Visible = false;
            ActualizarEstadoLocalidad();
            txtProvincia.Focus();
        }

        private void ActualizarEstadoLocalidad()
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
                ObtenerProvinciaNormalizada(),
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

            if (string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                MessageBox.Show("Seleccioná una provincia.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProvincia.Focus();
                return false;
            }

            if (!ProvinciaIngresadaEsValida())
            {
                MessageBox.Show("Seleccioná una provincia válida de la lista.", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProvincia.Focus();
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
            txtProvincia.Text = "Cordoba";
            chkActivo.Checked = true;
            lstProvincias.Visible = false;
            lstLocalidades.Visible = false;
            ActualizarEstadoLocalidad();
            txtDni.Focus();
        }

        private bool ProvinciaSeleccionadaEsCordoba()
        {
            return txtProvincia.Text.Trim().Equals("Cordoba", StringComparison.OrdinalIgnoreCase);
        }

        private bool ProvinciaIngresadaEsValida()
        {
            return provinciasDisponibles.Any(p => p.Equals(txtProvincia.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private string ObtenerProvinciaNormalizada()
        {
            return provinciasDisponibles.First(p => p.Equals(txtProvincia.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
