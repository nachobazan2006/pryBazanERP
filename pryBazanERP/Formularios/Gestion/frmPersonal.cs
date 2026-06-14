using pryBazanERP.Acceso_datos;
using pryBazanERP.Conexión;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pryBazanERP.Formulario
{
    public partial class frmPersonal : Form
    {
        private readonly LocalidadesAPI localidadesAPI = new LocalidadesAPI();
        private readonly Timer temporizadorBusquedaLocalidad = new Timer();
        private readonly int idUsuarioActual;
        private readonly Action<int> personalAsociado;
        private int idPersonalActual;
        private classConexion.PersonalDetalle personalActual;
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
            ConfigurarIconosFormulario();
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

                personalActual = personal;
                MostrarDatosCargados();
                VaciarInputsFichaCargada();
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

        private void ConfigurarIconosFormulario()
        {
            btnLimpiarDatos.Text = "Limpiar";
            btnLimpiarDomicilio.Text = "Limpiar";
            btnLimpiarDatos.Image = CrearIconoBoton("E74D", Color.FromArgb(84, 60, 42), 18);
            btnLimpiarDomicilio.Image = CrearIconoBoton("E74D", Color.FromArgb(84, 60, 42), 18);
            btnLimpiarDatos.ImageSize = new Size(14, 14);
            btnLimpiarDomicilio.ImageSize = new Size(14, 14);
            btnLimpiarDatos.ImageAlign = HorizontalAlignment.Left;
            btnLimpiarDomicilio.ImageAlign = HorizontalAlignment.Left;
        }

        private Image CrearIconoBoton(string codigoHex, Color color, int tamano)
        {
            Bitmap bitmap = new Bitmap(tamano, tamano);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Font fuente = new Font("Segoe MDL2 Assets", tamano - 3, FontStyle.Regular, GraphicsUnit.Pixel))
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.Clear(Color.Transparent);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                string texto = char.ConvertFromUtf32(Convert.ToInt32(codigoHex, 16));
                graphics.DrawString(texto, fuente, brush, new PointF(0, 0));
            }

            return bitmap;
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
            string dni = ObtenerValorParaGuardar(txtDni.Text, personalActual?.DNI);
            string apellido = ObtenerValorParaGuardar(txtApellido.Text, personalActual?.Apellido);
            string nombre = ObtenerValorParaGuardar(txtNombre.Text, personalActual?.Nombre);
            string direccion = ObtenerValorParaGuardar(txtDireccion.Text, personalActual?.Direccion);
            string geo = ObtenerValorParaGuardar(txtGeo.Text, personalActual?.Geo);
            string localidad = ObtenerValorParaGuardar(txtLocalidad.Text, personalActual?.Localidad);
            string provincia = ObtenerProvinciaParaGuardar();

            if (idPersonalActual > 0)
            {
                guardado = conexion.ActualizarPersonal(
                    idPersonalActual,
                    dni,
                    apellido,
                    nombre,
                    direccion,
                    geo,
                    localidad,
                    provincia,
                    chkActivo.Checked,
                    out mensaje);
            }
            else
            {
                int idPersonalCreado;
                guardado = conexion.GuardarPersonal(
                    dni,
                    apellido,
                    nombre,
                    direccion,
                    geo,
                    localidad,
                    provincia,
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
                if (idPersonalActual > 0)
                {
                    CargarPersonalActual();
                }
                else
                {
                    LimpiarCampos();
                }
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
            string dni = ObtenerValorParaGuardar(txtDni.Text, personalActual?.DNI);
            string apellido = ObtenerValorParaGuardar(txtApellido.Text, personalActual?.Apellido);
            string nombre = ObtenerValorParaGuardar(txtNombre.Text, personalActual?.Nombre);

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingresa el DNI.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Ingresa el apellido.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa el nombre.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProvincia.Text) && (personalActual == null || string.IsNullOrWhiteSpace(personalActual.Provincia)))
            {
                MessageBox.Show("Selecciona una provincia.", "Mi ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvincia.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtProvincia.Text) && !ProvinciaIngresadaEsValida())
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

        private void MostrarDatosCargados()
        {
            if (personalActual == null)
            {
                return;
            }

            lblResumenActualizado.Text = "Actualizado hoy " + DateTime.Now.ToString("HH:mm");
            lblResumenDniValor.Text = TextoOValor(personalActual.DNI);
            lblResumenApellidoValor.Text = TextoOValor(personalActual.Apellido);
            lblResumenNombreValor.Text = TextoOValor(personalActual.Nombre);
            
            
            
            lblResumenDomDireccionValor.Text = TextoOValor(personalActual.Direccion);
            lblResumenDomLocalidadValor.Text = TextoOValor(personalActual.Localidad);
            lblResumenDomProvinciaValor.Text = TextoOValor(personalActual.Provincia);
            lblResumenDomGeoValor.Text = TextoOValor(personalActual.Geo);
            lblResumenEstadoValor.Text = personalActual.Activo ? "Activo" : "Inactivo";
            pnlResumenEstado.BorderColor = personalActual.Activo ? Color.FromArgb(130, 192, 132) : Color.FromArgb(204, 133, 120);
            pnlResumenEstado.FillColor = personalActual.Activo ? Color.FromArgb(226, 242, 221) : Color.FromArgb(250, 226, 221);
            lblResumenEstadoValor.ForeColor = personalActual.Activo ? Color.FromArgb(54, 102, 52) : Color.FromArgb(135, 60, 50);
            grpDatosCargados.BringToFront();
        }

        private void CargarInputsFichaCargada()
        {
            txtDni.Text = TextoOValor(personalActual?.DNI) == "-" ? "" : personalActual.DNI;
            txtApellido.Text = TextoOValor(personalActual?.Apellido) == "-" ? "" : personalActual.Apellido;
            txtNombre.Text = TextoOValor(personalActual?.Nombre) == "-" ? "" : personalActual.Nombre;
            txtDireccion.Text = TextoOValor(personalActual?.Direccion) == "-" ? "" : personalActual.Direccion;
            txtGeo.Text = TextoOValor(personalActual?.Geo) == "-" ? "" : personalActual.Geo;
            txtProvincia.Text = TextoOValor(personalActual?.Provincia) == "-" ? "Cordoba" : personalActual.Provincia;
            txtLocalidad.Text = TextoOValor(personalActual?.Localidad) == "-" ? "" : personalActual.Localidad;
            chkActivo.Checked = personalActual == null || personalActual.Activo;
            lstProvincias.Visible = false;
            lstLocalidades.Visible = false;
            ActualizarEstadoLocalidad();
        }

        private void VaciarInputsFichaCargada()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtGeo.Clear();
            txtLocalidad.Clear();
            txtProvincia.Clear();
            chkActivo.Checked = personalActual == null || personalActual.Activo;
            lstProvincias.Visible = false;
            lstLocalidades.Visible = false;
            ActualizarEstadoLocalidad();
            txtDni.Focus();
        }

        private string ObtenerValorParaGuardar(string ingresado, string actual)
        {
            return string.IsNullOrWhiteSpace(ingresado) ? (actual ?? "") : ingresado.Trim();
        }

        private string ObtenerProvinciaParaGuardar()
        {
            if (!string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                return ObtenerProvinciaNormalizada();
            }

            if (personalActual != null && !string.IsNullOrWhiteSpace(personalActual.Provincia))
            {
                return personalActual.Provincia;
            }

            return "";
        }

        private string TextoOValor(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? "-" : valor;
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
