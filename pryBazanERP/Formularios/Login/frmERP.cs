using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryBazanERP.Conexión;
using pryBazanERP.Formulario;

namespace pryBazanERP
{
    public partial class frmERP : Form
    {
        int intentos = 3;
        private int posicionFinalCard;
        public frmERP()
        {

            InitializeComponent();
            AppIcon.Aplicar(this);
            ActualizarEstadoConexion();
        }

        private void frmERP_Load(object sender, EventArgs e)
        {
            posicionFinalCard = pnlCard.Left;
            pnlCard.Left += 28;
            pnlCard.Visible = true;
            loginTimer.Start();
            txtUsuario.Focus();
        }

        private void ActualizarEstadoConexion()
        {
            classConexion conexion = new classConexion();

            if (conexion.ProbarConexion())
            {
                lblEstado.Text = "Conectado";
                lblEstado.ForeColor = Color.FromArgb(68, 112, 74);
                pnlEstado.FillColor = Color.FromArgb(68, 112, 74);
            }
            else
            {
                lblEstado.Text = "No está conectado";
                lblEstado.ForeColor = Color.FromArgb(126, 76, 61);
                pnlEstado.FillColor = Color.FromArgb(126, 76, 61);
            }
        }
        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLogin())
            {
                return;
            }

            classConexion conexion = new classConexion();

            string usuario;
            string perfil;
            int idUsuario;
            int idPersonal;

            if (conexion.ObtenerDatosUsuario(txtUsuario.Text, txtContraseña.Text, out usuario, out perfil, out idUsuario, out idPersonal))
            {
                MessageBox.Show("Bienvenido, " + usuario + "!", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain(usuario, perfil, idUsuario, idPersonal);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                conexion.GrabarAuditoriaSesion(txtUsuario.Text, "Intento fallido");
                intentos--;
                MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + intentos, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (intentos == 0)
                {
                    MessageBox.Show("Has agotado tus intentos.", "Intentos agotados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContraseña.Enabled = false;
                    txtUsuario.Enabled = false;
                    btnIngresar.Enabled = false;
                }

            }
        }

        private bool ValidarCamposLogin()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el usuario o correo.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Focus();
                return false;
            }

            return true;
        }

        private void chkOcultarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOcultarContraseña.Checked == true)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else 
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if (pnlCard.Left <= posicionFinalCard)
            {
                pnlCard.Left = posicionFinalCard;
                loginTimer.Stop();
                return;
            }

            pnlCard.Left -= 4;
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
