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
    }
}
