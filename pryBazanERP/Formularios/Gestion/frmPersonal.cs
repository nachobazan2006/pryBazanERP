using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pryBazanERP.Acceso_datos;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmPersonal : Form
    {
        private readonly LocalidadesAPI localidadesAPI = new LocalidadesAPI();
        private readonly Timer temporizadorBusquedaLocalidad = new Timer();
        private readonly int idUsuarioActual;
        private readonly Action<int> personalAsociado;
        private int idPersonalActual;
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
        private bool seleccionandoLocalidad;

        public frmPersonal() : this(0, 0, null)
        {
        }

        public frmPersonal(int idPersonal) : this(0, idPersonal, null)
        {
        }

        public frmPersonal(int idUsuario, int idPersonal, Action<int> personalAsociado)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            idUsuarioActual = idUsuario;
            idPersonalActual = idPersonal;
            this.personalAsociado = personalAsociado;
            temporizadorBusquedaLocalidad.Interval = 450;
            temporizadorBusquedaLocalidad.Tick += temporizadorBusquedaLocalidad_Tick;
            txtProvincia.Text = "Cordoba";
            ActualizarEstadoLocalidad();
            _ = localidadesAPI.PrecargarLocalidadesCordobaAsync();

            if (idPersonalActual > 0)
            {
                CargarPersonalActual();
            }
            else
            {
                btnGuardar.Text = "Guardar mi ficha";
            }

            if (idUsuarioActual == 0)
            {
                BloquearSinSesion();
            }
        }

        private void CargarPersonalActual()
        {
            try
            {
                classConexion conexion = new classConexion();
                classConexion.PersonalDetalle personal = conexion.ObtenerPersonalDetalle(idPersonalActual);

                if (personal == null)
                {
                    BloquearSinPersonalAsociado();
                    return;
                }

                txtDni.Text = personal.DNI;
                txtApellido.Text = personal.Apellido;
                txtNombre.Text = personal.Nombre;
                txtDireccion.Text = personal.Direccion;
                txtGeo.Text = personal.Geo;
                txtLocalidad.Text = personal.Localidad;
                txtProvincia.Text = string.IsNullOrWhiteSpace(personal.Provincia) ? "Cordoba" : personal.Provincia;
                chkActivo.Checked = personal.Activo;
                btnGuardar.Text = "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar tus datos personales: " + ex.Message, "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BloquearSinPersonalAsociado();
            }
        }

        private void BloquearSinPersonalAsociado()
        {
            MessageBox.Show("El usuario actual no tiene un personal asociado. No se pueden editar datos personales desde este modulo.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpDatos.Enabled = false;
            grpDomicilio.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiarDatos.Enabled = false;
            btnLimpiarDomicilio.Enabled = false;
        }

        private void BloquearSinSesion()
        {
            MessageBox.Show("No se pudo identificar la sesion actual. Ingresá nuevamente para acceder a Mi ficha.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpDatos.Enabled = false;
            grpDomicilio.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiarDatos.Enabled = false;
            btnLimpiarDomicilio.Enabled = false;
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

        private void txtProvincia_Leave(object sender, EventArgs e)
        {
            OcultarProvinciasSiNoEstanEnFoco();
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

        private void lstProvincias_Leave(object sender, EventArgs e)
        {
            OcultarProvinciasSiNoEstanEnFoco();
        }

        private void OcultarProvinciasSiNoEstanEnFoco()
        {
            BeginInvoke(new Action(() =>
            {
                if (!txtProvincia.Focused && !lstProvincias.Focused)
                {
                    lstProvincias.Visible = false;
                }
            }));
        }

        private void MostrarProvinciasFiltradas()
        {
            string texto = txtProvincia.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto) || ProvinciaIngresadaEsValida())
            {
                lstProvincias.Visible = false;
                return;
            }

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

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            temporizadorBusquedaLocalidad.Stop();
            lstLocalidades.Visible = false;

            if (!seleccionandoLocalidad && ProvinciaSeleccionadaEsCordoba() && txtLocalidad.Text.Trim().Length >= 2)
            {
                temporizadorBusquedaLocalidad.Start();
            }
        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {
            OcultarLocalidadesSiNoEstanEnFoco();
        }

        private async void temporizadorBusquedaLocalidad_Tick(object sender, EventArgs e)
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

                List<string> localidades = await localidadesAPI.BuscarLocalidadesCordobaAsync(textoBuscado);

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
                lstLocalidades.BringToFront();
            }
            catch
            {
                lstLocalidades.Visible = false;
            }
        }

        private void lstLocalidades_Click(object sender, EventArgs e)
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

        private void lstLocalidades_Leave(object sender, EventArgs e)
        {
            OcultarLocalidadesSiNoEstanEnFoco();
        }

        private void OcultarLocalidadesSiNoEstanEnFoco()
        {
            BeginInvoke(new Action(() =>
            {
                if (!txtLocalidad.Focused && !lstLocalidades.Focused)
                {
                    lstLocalidades.Visible = false;
                }
            }));
        }

        private void SeleccionarLocalidad()
        {
            if (lstLocalidades.SelectedItem == null)
            {
                return;
            }

            seleccionandoLocalidad = true;
            txtLocalidad.Text = lstLocalidades.SelectedItem.ToString();
            txtLocalidad.SelectionStart = txtLocalidad.Text.Length;
            seleccionandoLocalidad = false;
            lstLocalidades.Visible = false;
            txtLocalidad.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            classConexion conexion = new classConexion();
            string mensaje;

            bool guardado;

            if (idPersonalActual > 0)
            {
                guardado = conexion.ActualizarPersonal(
                    idPersonalActual,
                    txtDni.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtGeo.Text.Trim(),
                    txtLocalidad.Text.Trim(),
                    ObtenerProvinciaNormalizada(),
                    chkActivo.Checked,
                    out mensaje);
            }
            else
            {
                int idPersonalCreado;
                guardado = conexion.GuardarPersonal(
                    txtDni.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtGeo.Text.Trim(),
                    txtLocalidad.Text.Trim(),
                    ObtenerProvinciaNormalizada(),
                    chkActivo.Checked,
                    out mensaje,
                    out idPersonalCreado);

                if (guardado && idUsuarioActual > 0)
                {
                    string mensajeAsociacion;
                    if (conexion.AsociarUsuarioPersonal(idUsuarioActual, idPersonalCreado, out mensajeAsociacion))
                    {
                        idPersonalActual = idPersonalCreado;
                        personalAsociado?.Invoke(idPersonalCreado);
                        btnGuardar.Text = "Actualizar";
                    }
                    else
                    {
                        MessageBox.Show(mensajeAsociacion, "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            MessageBox.Show(
                mensaje,
                "Mi ficha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (guardado)
            {
                LimpiarCampos();
            }
        }


        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarDatosPersonales();
        }

        private void btnLimpiarDomicilio_Click(object sender, EventArgs e)
        {
            LimpiarDomicilio();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingresa el DNI.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingresa el apellido.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                MessageBox.Show("Selecciona una provincia.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvincia.Focus();
                return false;
            }

            if (!ProvinciaIngresadaEsValida())
            {
                MessageBox.Show("Selecciona una provincia valida de la lista.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvincia.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            LimpiarDatosPersonales();
            LimpiarDomicilio();
            txtDni.Focus();
        }

        private void LimpiarDatosPersonales()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            chkActivo.Checked = true;
            txtDni.Focus();
        }

        private void LimpiarDomicilio()
        {
            txtDireccion.Clear();
            txtGeo.Clear();
            txtLocalidad.Clear();
            txtProvincia.Text = "Cordoba";
            lstProvincias.Visible = false;
            lstLocalidades.Visible = false;
            ActualizarEstadoLocalidad();
            txtDireccion.Focus();
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
