using System;
using System.Drawing;
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
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2Button btnEstadoUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
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
            lblHora.Text = "Inicio de sesión: " + DateTime.Now.ToShortTimeString();

            ConfigurarModuloGenerarUsuarios();
            ConfigurarBotonCerrarSesion();
            ConfigurarIconosSidebar();
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo los administradores pueden ver reportes.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnReportes.Checked = true;
            AbrirFormularioEnPanel(new frmReportes(true));
        }

        private void btnEstadoUsuarios_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo los administradores pueden gestionar usuarios.", "Estado de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnEstadoUsuarios.Checked = true;
            AbrirFormularioEnPanel(new frmEstadoUsuarios(idUsuario, mail, true));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Deseas cerrar la sesion actual?",
                "Cerrar sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            classConexion conexion = new classConexion();
            conexion.GrabarAuditoriaSesion(mail, "Cierre de sesion");

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario is pryBazanERP.frmERP)
                {
                    formulario.Show();
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                    Close();
                    return;
                }
            }

            pryBazanERP.frmERP login = new pryBazanERP.frmERP();
            login.Show();
            Close();
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
            btnGenerarUsuarios.Padding = new Padding(14, 0, 0, 0);
            btnGenerarUsuarios.Size = new Size(196, 46);
            btnGenerarUsuarios.Text = "Usuarios";
            btnGenerarUsuarios.TextAlign = HorizontalAlignment.Left;
            btnGenerarUsuarios.Click += btnGenerarUsuarios_Click;
            pnlSidebar.Controls.Add(btnGenerarUsuarios);

            btnAuditoria = CrearBotonMenuAdmin("btnAuditoria", "Auditoria", 344);
            btnAuditoria.Click += btnAuditoria_Click;
            pnlSidebar.Controls.Add(btnAuditoria);

            btnEstadoUsuarios = CrearBotonMenuAdmin("btnEstadoUsuarios", "Estado usuarios", 400);
            btnEstadoUsuarios.Click += btnEstadoUsuarios_Click;
            pnlSidebar.Controls.Add(btnEstadoUsuarios);

            btnReportes = CrearBotonMenuAdmin("btnReportes", "Reportes", 456);
            btnReportes.Click += btnReportes_Click;
            pnlSidebar.Controls.Add(btnReportes);
        }

        private void ConfigurarBotonCerrarSesion()
        {
            btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            btnCerrarSesion.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btnCerrarSesion.Animated = true;
            btnCerrarSesion.BorderColor = Color.FromArgb(218, 198, 174);
            btnCerrarSesion.BorderRadius = 12;
            btnCerrarSesion.BorderThickness = 1;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FillColor = Color.FromArgb(246, 238, 226);
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(72, 48, 34);
            btnCerrarSesion.HoverState.FillColor = Color.FromArgb(218, 198, 174);
            btnCerrarSesion.Location = new Point(22, pnlSidebar.Height - 72);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(14, 0, 0, 0);
            btnCerrarSesion.Size = new Size(196, 46);
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.TextAlign = HorizontalAlignment.Left;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            pnlSidebar.Controls.Add(btnCerrarSesion);
            btnCerrarSesion.BringToFront();
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
            boton.Padding = new Padding(14, 0, 0, 0);
            boton.Size = new Size(196, 46);
            boton.Text = texto;
            boton.TextAlign = HorizontalAlignment.Left;
            return boton;
        }

        private void ConfigurarIconosSidebar()
        {
            ConfigurarIconoBotonMenu(btnPersonal, "E77B");
            ConfigurarIconoBotonMenu(btnContacto, "E716");
            ConfigurarIconoBotonMenu(btnUsuarioPerfil, "E77B");
            ConfigurarIconoBotonMenu(btnGenerarUsuarios, "E716");
            ConfigurarIconoBotonMenu(btnAuditoria, "E83D");
            ConfigurarIconoBotonMenu(btnEstadoUsuarios, "E9D2");
            ConfigurarIconoBotonMenu(btnReportes, "E8A5");
            ConfigurarIconoBotonMenu(btnCerrarSesion, "E8AC");
        }

        private void ConfigurarIconoBotonMenu(Guna.UI2.WinForms.Guna2Button boton, string codigoHex)
        {
            if (boton == null)
            {
                return;
            }

            boton.Tag = codigoHex;
            boton.ImageAlign = HorizontalAlignment.Left;
            boton.ImageSize = new Size(18, 18);
            boton.Padding = new Padding(14, 0, 0, 0);
            boton.TextOffset = new Point(8, 0);
            boton.CheckedChanged -= BotonMenu_CheckedChanged;
            boton.CheckedChanged += BotonMenu_CheckedChanged;
            ActualizarIconoBotonMenu(boton);
        }

        private void BotonMenu_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarIconoBotonMenu(sender as Guna.UI2.WinForms.Guna2Button);
        }

        private void ActualizarIconoBotonMenu(Guna.UI2.WinForms.Guna2Button boton)
        {
            if (boton == null || boton.Tag == null)
            {
                return;
            }

            Color colorIcono = boton.Checked ? Color.FromArgb(72, 48, 34) : Color.White;
            boton.Image = CrearIconoSidebar(boton.Tag.ToString(), colorIcono, 22);
        }

        private Image CrearIconoSidebar(string codigoHex, Color color, int tamano)
        {
            Bitmap bitmap = new Bitmap(tamano, tamano);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Font fuente = new Font("Segoe MDL2 Assets", tamano - 3, FontStyle.Regular, GraphicsUnit.Pixel))
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.Clear(Color.Transparent);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                string texto = char.ConvertFromUtf32(Convert.ToInt32(codigoHex, 16));
                graphics.DrawString(texto, fuente, brush, new PointF(1, 1));
            }

            return bitmap;
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
