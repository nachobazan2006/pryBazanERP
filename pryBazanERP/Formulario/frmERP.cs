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

namespace pryBazanERP
{
    public partial class frmERP : Form
    {
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
    }
}
