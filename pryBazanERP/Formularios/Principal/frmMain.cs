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
  
namespace pryBazanERP.Formulario
{
    public partial class frmMain : Form
    {
        private string usuario;
        private string perfil;
        private Form formularioActivo;
        private int posicionFinalFormulario;

        public frmMain(string usuario, string perfil)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.perfil = perfil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Usuario: " + usuario; 
            lblPerfil.Text = "Perfil: " + perfil; 
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            lblHora.Text = "Hora: " + DateTime.Now.ToShortTimeString(); 
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            btnPersonal.Checked = true;
            AbrirFormularioEnPanel(new frmPersonal());
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            btnContacto.Checked = true;
            AbrirFormularioEnPanel(new frmContacto());
        }

        private void btnUsuarioPerfil_Click(object sender, EventArgs e)
        {
            btnUsuarioPerfil.Checked = true;
            AbrirFormularioEnPanel(new frmUsuarioPerfil());
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            fadeTimer.Stop();
            pnlContenido.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(formulario);
            formulario.Show();

            formularioActivo = formulario;
            posicionFinalFormulario = formulario.Left;
            formulario.Left += 18;
            fadeTimer.Start();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (formularioActivo == null)
            {
                fadeTimer.Stop();
                return;
            }

            if (formularioActivo.Left <= posicionFinalFormulario)
            {
                formularioActivo.Left = posicionFinalFormulario;
                fadeTimer.Stop();
                return;
            }

            formularioActivo.Left -= 3;
        }
    }
}
