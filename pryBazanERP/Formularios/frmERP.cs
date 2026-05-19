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
        public frmERP()
        {
            
            InitializeComponent();
            ActualizarEstadoConexion();
        }
        private void ActualizarEstadoConexion() 
        {
            classConexion conexion = new classConexion();

            if (conexion.ProbarConexion())
            {
                lblEstado.Text = "Conectado";
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.Text = "No está conectado";
                lblEstado.ForeColor = Color.Red;
            }
        }
        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            classConexion conexion = new classConexion();

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (conexion.ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Bienvenido, " + usuario + "!", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                intentos--;
                MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + intentos, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (intentos == 0)
                {
                    MessageBox.Show("Has agotado tus intentos.", "Intentos agotados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Enabled = false;
                    txtUsuario.Enabled = false;
                    btnIngresar.Enabled = false;
                }
             
            }
        }
    }
}
