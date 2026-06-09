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
        private string mail;
        private int idUsuario;
        private int idPersonal;
        private Form formularioActivo;
        private Guna.UI2.WinForms.Guna2Button btnGenerarUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnAuditoria;
        private bool avisoFichaMostrado;
        private int posicionFinalFormulario;

        public frmMain(string usuario, string perfil, string mail, int idUsuario, int idPersonal)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.usuario = usuario;
            this.perfil = perfil;
            this.mail = mail;
            this.idUsuario = idUsuario;
            this.idPersonal = idPersonal;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Usuario: " + usuario; 
            lblPerfil.Text = "Perfil: " + perfil; 
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            lblHora.Text = "Hora: " + DateTime.Now.ToShortTimeString();

            ConfigurarModuloGenerarUsuarios();
            ActualizarEstadoPersonal();

            if (!TienePersonalAsociado())
            {
                MostrarAvisoFichaPendiente();
                btnPersonal.Checked = true;
                AbrirFormularioEnPanel(new frmPersonal(idUsuario, idPersonal, ActualizarPersonalSesion));
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            btnPersonal.Checked = true;
            AbrirFormularioEnPanel(new frmPersonal(idUsuario, idPersonal, ActualizarPersonalSesion));
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            if (!TienePersonalAsociado())
            {
                MostrarAvisoFichaPendiente();
                btnPersonal.Checked = true;
                AbrirFormularioEnPanel(new frmPersonal(idUsuario, idPersonal, ActualizarPersonalSesion));
                return;
            }

            btnContacto.Checked = true;
            AbrirFormularioEnPanel(new frmContacto(idPersonal, usuario));
        }

        private void btnUsuarioPerfil_Click(object sender, EventArgs e)
        {
            btnUsuarioPerfil.Checked = true;
            AbrirFormularioEnPanel(new frmUsuarioPerfil(idUsuario, usuario, mail, perfil, idPersonal));
        }

        private void btnGenerarUsuarios_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo los administradores pueden generar usuarios.", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnGenerarUsuarios.Checked = true;
            AbrirFormularioEnPanel(new frmGenerarUsuario(mail, true));
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo los administradores pueden ver la auditoria.", "Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnAuditoria.Checked = true;
            AbrirFormularioEnPanel(new frmAuditoriaSesion(true));
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
            ActualizarEstadoPersonal();
        }

        private void ConfigurarModuloGenerarUsuarios()
        {
            if (!EsAdministrador())
            {
                return;
            }

            btnGenerarUsuarios = new Guna.UI2.WinForms.Guna2Button();
            btnGenerarUsuarios.Animated = true;
            btnGenerarUsuarios.BorderRadius = 12;
            btnGenerarUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnGenerarUsuarios.CheckedState.FillColor = Color.FromArgb(246, 238, 226);
            btnGenerarUsuarios.CheckedState.ForeColor = Color.FromArgb(72, 48, 34);
            btnGenerarUsuarios.Cursor = Cursors.Hand;
            btnGenerarUsuarios.FillColor = Color.FromArgb(111, 74, 45);
            btnGenerarUsuarios.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGenerarUsuarios.ForeColor = Color.White;
            btnGenerarUsuarios.HoverState.FillColor = Color.FromArgb(150, 111, 76);
            btnGenerarUsuarios.Location = new Point(22, 288);
            btnGenerarUsuarios.Name = "btnGenerarUsuarios";
            btnGenerarUsuarios.Padding = new Padding(12, 0, 0, 0);
            btnGenerarUsuarios.Size = new Size(196, 46);
            btnGenerarUsuarios.Text = "Usuarios";
            btnGenerarUsuarios.TextAlign = HorizontalAlignment.Left;
            btnGenerarUsuarios.Click += btnGenerarUsuarios_Click;
            pnlSidebar.Controls.Add(btnGenerarUsuarios);

            btnAuditoria = CrearBotonMenuAdmin("btnAuditoria", "Auditoria", 344);
            btnAuditoria.Click += btnAuditoria_Click;
            pnlSidebar.Controls.Add(btnAuditoria);
        }

        private Guna.UI2.WinForms.Guna2Button CrearBotonMenuAdmin(string nombre, string texto, int y)
        {
            Guna.UI2.WinForms.Guna2Button boton = new Guna.UI2.WinForms.Guna2Button();
            boton.Animated = true;
            boton.BorderRadius = 12;
            boton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            boton.CheckedState.FillColor = Color.FromArgb(246, 238, 226);
            boton.CheckedState.ForeColor = Color.FromArgb(72, 48, 34);
            boton.Cursor = Cursors.Hand;
            boton.FillColor = Color.FromArgb(111, 74, 45);
            boton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            boton.ForeColor = Color.White;
            boton.HoverState.FillColor = Color.FromArgb(150, 111, 76);
            boton.Location = new Point(22, y);
            boton.Name = nombre;
            boton.Padding = new Padding(12, 0, 0, 0);
            boton.Size = new Size(196, 46);
            boton.Text = texto;
            boton.TextAlign = HorizontalAlignment.Left;
            return boton;
        }

        private bool EsAdministrador()
        {
            return perfil != null && perfil.IndexOf("Administrador", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private bool TienePersonalAsociado()
        {
            return idPersonal > 0;
        }

        private void ActualizarEstadoPersonal()
        {
            btnContacto.Enabled = true;
            btnContacto.FillColor = Color.FromArgb(111, 74, 45);
            btnContacto.ForeColor = Color.White;
            btnContacto.HoverState.FillColor = Color.FromArgb(150, 111, 76);
            btnContacto.Cursor = Cursors.Hand;
            btnContacto.Text = "Contactos";

            if (TienePersonalAsociado())
            {
                lblInicioTitulo.Text = "Resumen";
                lblInicioDetalle.Text = "Seleccione una opcion del menu para comenzar.";
            }
            else
            {
                lblInicioTitulo.Text = "Completa tu ficha";
                lblInicioDetalle.Text = "Antes de cargar contactos, completa tus datos personales.";
            }
        }

        private void MostrarAvisoFichaPendiente()
        {
            if (avisoFichaMostrado)
            {
                return;
            }

            avisoFichaMostrado = true;
            MessageBox.Show(
                "Primero completa tu ficha en 'Mi ficha'. Despues vas a poder entrar a Contactos.",
                "Ficha pendiente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
