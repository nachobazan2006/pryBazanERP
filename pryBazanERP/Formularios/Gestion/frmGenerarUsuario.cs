using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmGenerarUsuario : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly string usuarioAdministrador;
        private readonly bool esAdministrador;

        public frmGenerarUsuario() : this("", false)
        {
        }

        public frmGenerarUsuario(string usuarioAdministrador) : this(usuarioAdministrador, false)
        {
        }

        public frmGenerarUsuario(string usuarioAdministrador, bool esAdministrador)
        {
            this.usuarioAdministrador = usuarioAdministrador;
            this.esAdministrador = esAdministrador;
            InitializeComponent();
            AppIcon.Aplicar(this);
            CargarPerfiles();

            if (!this.esAdministrador)
            {
                BloquearSinPermiso();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosBase())
            {
                return;
            }

            string usuarioBase = CrearNombreUsuario(txtNombre.Text, txtApellido.Text);
            txtUsuario.Text = conexion.ObtenerNombreUsuarioDisponible(usuarioBase);
            txtContrasena.Text = GenerarContrasena();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosBase())
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                btnGenerar.PerformClick();

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    return;
                }
            }

            string mensaje;
            bool guardado = conexion.GuardarUsuarioGenerado(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text,
                ObtenerPerfilSeleccionado(),
                out mensaje);

            MessageBox.Show(mensaje, "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (guardado)
            {
                conexion.GrabarAuditoriaSesion(TextoAuditoria(), "Genero usuario: " + txtUsuario.Text.Trim());
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = chkMostrar.Checked ? '\0' : '*';
        }

        private bool ValidarDatosBase()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Focus();
                return false;
            }

            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol.", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPerfil.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            chkMostrar.Checked = false;

            if (cmbPerfil.Items.Count > 0)
            {
                cmbPerfil.SelectedIndex = 0;
            }

            txtNombre.Focus();
        }

        private string TextoAuditoria()
        {
            return string.IsNullOrWhiteSpace(usuarioAdministrador) ? "Administrador" : usuarioAdministrador;
        }

        private string CrearNombreUsuario(string nombre, string apellido)
        {
            string nombreLimpio = LimpiarParaUsuario(nombre);
            string apellidoLimpio = LimpiarParaUsuario(apellido);

            if (nombreLimpio.Length == 0)
            {
                nombreLimpio = "u";
            }

            if (apellidoLimpio.Length == 0)
            {
                apellidoLimpio = "usuario";
            }

            return (nombreLimpio.Substring(0, 1) + apellidoLimpio).ToLowerInvariant();
        }

        private string LimpiarParaUsuario(string texto)
        {
            string normalizado = texto.Trim().Normalize(NormalizationForm.FormD);
            StringBuilder limpio = new StringBuilder();

            foreach (char caracter in normalizado)
            {
                UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(caracter);

                if (categoria != UnicodeCategory.NonSpacingMark && char.IsLetterOrDigit(caracter))
                {
                    limpio.Append(caracter);
                }
            }

            return Regex.Replace(limpio.ToString(), "[^a-zA-Z0-9]", "");
        }

        private string GenerarContrasena()
        {
            const string caracteres = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789!@$%";
            char[] contrasena = new char[8];
            byte[] bytes = new byte[8];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            for (int i = 0; i < contrasena.Length; i++)
            {
                contrasena[i] = caracteres[bytes[i] % caracteres.Length];
            }

            return new string(contrasena);
        }

        private void CargarPerfiles()
        {
            cmbPerfil.Items.Clear();

            foreach (string perfil in conexion.ObtenerPerfilesDisponibles())
            {
                cmbPerfil.Items.Add(perfil);
            }

            if (cmbPerfil.Items.Count > 0)
            {
                cmbPerfil.SelectedIndex = 0;
            }
        }

        private string ObtenerPerfilSeleccionado()
        {
            if (cmbPerfil != null && cmbPerfil.SelectedItem != null)
            {
                return cmbPerfil.SelectedItem.ToString();
            }

            return "Lector";
        }

        private void BloquearSinPermiso()
        {
            MessageBox.Show("No tenes permisos para generar usuarios.", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpDatos.Enabled = false;
            grpCredenciales.Enabled = false;
            btnGenerar.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
        }
    }
}
