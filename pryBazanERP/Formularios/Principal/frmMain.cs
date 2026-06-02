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
        private int idUsuario;
        private int idPersonal;
        private Form formularioActivo;
        private int posicionFinalFormulario;

        public frmMain(string usuario, string perfil, int idUsuario, int idPersonal)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.usuario = usuario;
            this.perfil = perfil;
            this.idUsuario = idUsuario;
            this.idPersonal = idPersonal;
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
            AbrirFormularioEnPanel(new frmPersonal(idUsuario, idPersonal, ActualizarPersonalSesion));
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            btnContacto.Checked = true;
            AbrirFormularioEnPanel(new frmContacto(idPersonal, usuario));
        }

        private void btnUsuarioPerfil_Click(object sender, EventArgs e)
        {
            btnUsuarioPerfil.Checked = true;
            AbrirFormularioEnPanel(new frmUsuarioPerfil(idUsuario));
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

        private void ActualizarPersonalSesion(int idPersonalNuevo)
        {
            idPersonal = idPersonalNuevo;
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

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
