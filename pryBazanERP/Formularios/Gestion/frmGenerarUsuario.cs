using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public class frmGenerarUsuario : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly string usuarioAdministrador;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasena;
        private Guna.UI2.WinForms.Guna2Button btnGenerar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2CheckBox chkMostrar;

        public frmGenerarUsuario()
            : this("")
        {
        }

        public frmGenerarUsuario(string usuarioAdministrador)
        {
            this.usuarioAdministrador = usuarioAdministrador;
            InitializeComponent();
            AppIcon.Aplicar(this);
        }

        private void InitializeComponent()
        {
            BackColor = Color.FromArgb(232, 218, 198);
            ClientSize = new Size(800, 580);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bazan ERP - Generar usuario";

            Label lblTitulo = CrearTitulo("Generar usuario", 34, 26, 24F);
            Label lblSubtitulo = CrearTexto("Alta administrativa de credenciales iniciales", 39, 74, 10F);

            Guna.UI2.WinForms.Guna2Panel grpDatos = CrearCard(40, 118, 330, 276);
            grpDatos.Controls.Add(CrearTitulo("Datos de la persona", 22, 18, 12F));
            grpDatos.Controls.Add(CrearEtiqueta("Nombre", 24, 61));
            txtNombre = CrearTextBox("Nombre", 26, 80);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(CrearEtiqueta("Apellido", 24, 125));
            txtApellido = CrearTextBox("Apellido", 26, 144);
            grpDatos.Controls.Add(txtApellido);
            btnGenerar = CrearBotonPrincipal("Generar credenciales", 26, 212, 180, 38);
            btnGenerar.Click += btnGenerar_Click;
            grpDatos.Controls.Add(btnGenerar);
            btnLimpiar = CrearBotonSecundario("Limpiar", 219, 18);
            btnLimpiar.Click += btnLimpiar_Click;
            grpDatos.Controls.Add(btnLimpiar);

            Guna.UI2.WinForms.Guna2Panel grpCredenciales = CrearCard(402, 118, 330, 276);
            grpCredenciales.Controls.Add(CrearTitulo("Credenciales iniciales", 22, 18, 12F));
            grpCredenciales.Controls.Add(CrearEtiqueta("Usuario", 24, 61));
            txtUsuario = CrearTextBox("Usuario generado", 26, 80);
            txtUsuario.ReadOnly = true;
            grpCredenciales.Controls.Add(txtUsuario);
            grpCredenciales.Controls.Add(CrearEtiqueta("Contrasena inicial", 24, 125));
            txtContrasena = CrearTextBox("Contrasena segura", 26, 144);
            txtContrasena.ReadOnly = true;
            txtContrasena.PasswordChar = '*';
            grpCredenciales.Controls.Add(txtContrasena);
            chkMostrar = new Guna.UI2.WinForms.Guna2CheckBox();
            chkMostrar.AutoSize = true;
            chkMostrar.Text = "Mostrar contrasena";
            chkMostrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkMostrar.ForeColor = Color.FromArgb(84, 60, 42);
            chkMostrar.Location = new Point(26, 188);
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            grpCredenciales.Controls.Add(chkMostrar);
            Label lblAviso = CrearTexto("Entregar estos datos y pedir cambio de contrasena al ingresar.", 26, 220, 8.7F);
            lblAviso.Size = new Size(282, 36);
            grpCredenciales.Controls.Add(lblAviso);

            btnGuardar = CrearBotonPrincipal("Guardar", 252, 430, 140, 42);
            btnGuardar.Click += btnGuardar_Click;

            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(grpDatos);
            Controls.Add(grpCredenciales);
            Controls.Add(btnGuardar);
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

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            chkMostrar.Checked = false;
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

        private Guna.UI2.WinForms.Guna2Panel CrearCard(int x, int y, int ancho, int alto)
        {
            Guna.UI2.WinForms.Guna2Panel card = new Guna.UI2.WinForms.Guna2Panel();
            card.BorderColor = Color.FromArgb(218, 198, 174);
            card.BorderRadius = 16;
            card.BorderThickness = 1;
            card.FillColor = Color.FromArgb(246, 238, 226);
            card.Location = new Point(x, y);
            card.Size = new Size(ancho, alto);
            card.ShadowDecoration.Color = Color.FromArgb(120, 92, 64);
            card.ShadowDecoration.Depth = 8;
            card.ShadowDecoration.Enabled = true;
            return card;
        }

        private Label CrearTitulo(string texto, int x, int y, float tamano)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", tamano, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(72, 48, 34);
            label.Location = new Point(x, y);
            label.Text = texto;
            return label;
        }

        private Label CrearEtiqueta(string texto, int x, int y)
        {
            Label label = CrearTexto(texto, x, y, 9F);
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            return label;
        }

        private Label CrearTexto(string texto, int x, int y, float tamano)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", tamano);
            label.ForeColor = Color.FromArgb(120, 92, 64);
            label.Location = new Point(x, y);
            label.Text = texto;
            return label;
        }

        private Guna.UI2.WinForms.Guna2TextBox CrearTextBox(string placeholder, int x, int y)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = new Guna.UI2.WinForms.Guna2TextBox();
            textBox.BorderColor = Color.FromArgb(218, 198, 174);
            textBox.BorderRadius = 12;
            textBox.Cursor = Cursors.IBeam;
            textBox.FillColor = Color.FromArgb(255, 250, 243);
            textBox.FocusedState.BorderColor = Color.FromArgb(111, 74, 45);
            textBox.Font = new Font("Segoe UI", 10F);
            textBox.ForeColor = Color.FromArgb(72, 48, 34);
            textBox.Location = new Point(x, y);
            textBox.PlaceholderText = placeholder;
            textBox.Size = new Size(278, 36);
            return textBox;
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonPrincipal(string texto, int x, int y, int ancho, int alto)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderRadius = 12;
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(111, 74, 45);
            boton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            boton.ForeColor = Color.White;
            boton.HoverState.FillColor = Color.FromArgb(84, 60, 42);
            boton.Location = new Point(x, y);
            boton.Size = new Size(ancho, alto);
            boton.Text = texto;
            return boton;
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonSecundario(string texto, int x, int y)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderColor = Color.FromArgb(150, 111, 76);
            boton.BorderRadius = 8;
            boton.BorderThickness = 1;
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(255, 250, 243);
            boton.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            boton.ForeColor = Color.FromArgb(84, 60, 42);
            boton.HoverState.FillColor = Color.FromArgb(218, 198, 174);
            boton.Location = new Point(x, y);
            boton.Size = new Size(85, 28);
            boton.Text = texto;
            return boton;
        }
    }
}
