namespace pryBazanERP.Formulario
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlRoot = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.cardInicio = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInicioDetalle = new System.Windows.Forms.Label();
            this.lblInicioTitulo = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDatos = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLinea = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDatosTitulo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsuarioPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnContacto = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlRoot.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.cardInicio.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.Controls.Add(this.pnlContenido);
            this.pnlRoot.Controls.Add(this.pnlHeader);
            this.pnlRoot.Controls.Add(this.pnlSidebar);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1120, 700);
            this.pnlRoot.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenido.Controls.Add(this.cardInicio);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlContenido.Location = new System.Drawing.Point(240, 92);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(28);
            this.pnlContenido.Size = new System.Drawing.Size(880, 608);
            this.pnlContenido.TabIndex = 2;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // cardInicio
            // 
            this.cardInicio.BackColor = System.Drawing.Color.Transparent;
            this.cardInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cardInicio.BorderRadius = 16;
            this.cardInicio.BorderThickness = 1;
            this.cardInicio.Controls.Add(this.lblInicioDetalle);
            this.cardInicio.Controls.Add(this.lblInicioTitulo);
            this.cardInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.cardInicio.Location = new System.Drawing.Point(32, 32);
            this.cardInicio.Name = "cardInicio";
            this.cardInicio.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.cardInicio.ShadowDecoration.Depth = 10;
            this.cardInicio.ShadowDecoration.Enabled = true;
            this.cardInicio.Size = new System.Drawing.Size(500, 150);
            this.cardInicio.TabIndex = 0;
            // 
            // lblInicioDetalle
            // 
            this.lblInicioDetalle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInicioDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblInicioDetalle.Location = new System.Drawing.Point(28, 78);
            this.lblInicioDetalle.Name = "lblInicioDetalle";
            this.lblInicioDetalle.Size = new System.Drawing.Size(420, 45);
            this.lblInicioDetalle.TabIndex = 1;
            this.lblInicioDetalle.Text = "Seleccione una opcion del menu para comenzar.";
            // 
            // lblInicioTitulo
            // 
            this.lblInicioTitulo.AutoSize = true;
            this.lblInicioTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold);
            this.lblInicioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblInicioTitulo.Location = new System.Drawing.Point(24, 25);
            this.lblInicioTitulo.Name = "lblInicioTitulo";
            this.lblInicioTitulo.Size = new System.Drawing.Size(321, 42);
            this.lblInicioTitulo.TabIndex = 0;
            this.lblInicioTitulo.Text = "Bienvenido al sistema";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.pnlDatos);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.pnlHeader.Location = new System.Drawing.Point(240, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 92);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.pnlDatos.BorderRadius = 14;
            this.pnlDatos.BorderThickness = 1;
            this.pnlDatos.Controls.Add(this.pnlLinea);
            this.pnlDatos.Controls.Add(this.lblDatosTitulo);
            this.pnlDatos.Controls.Add(this.lblHora);
            this.pnlDatos.Controls.Add(this.lblFecha);
            this.pnlDatos.Controls.Add(this.lblPerfil);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.pnlDatos.Location = new System.Drawing.Point(570, 13);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(286, 66);
            this.pnlDatos.TabIndex = 2;
            // 
            // pnlLinea
            // 
            this.pnlLinea.BorderRadius = 3;
            this.pnlLinea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.pnlLinea.Location = new System.Drawing.Point(13, 12);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(5, 42);
            this.pnlLinea.TabIndex = 5;
            // 
            // lblDatosTitulo
            // 
            this.lblDatosTitulo.AutoSize = true;
            this.lblDatosTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblDatosTitulo.Location = new System.Drawing.Point(28, 8);
            this.lblDatosTitulo.Name = "lblDatosTitulo";
            this.lblDatosTitulo.Size = new System.Drawing.Size(90, 15);
            this.lblDatosTitulo.TabIndex = 4;
            this.lblDatosTitulo.Text = "Datos de sesion";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblHora.Location = new System.Drawing.Point(150, 46);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(91, 15);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Inicio de sesión:";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblFecha.Location = new System.Drawing.Point(28, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPerfil.Location = new System.Drawing.Point(150, 24);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 15);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Usuario:";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(31, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(163, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Panel principal del sistema";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de gestion";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Controls.Add(this.btnUsuarioPerfil);
            this.pnlSidebar.Controls.Add(this.btnContacto);
            this.pnlSidebar.Controls.Add(this.btnPersonal);
            this.pnlSidebar.Controls.Add(this.lblMenuTitulo);
            this.pnlSidebar.Controls.Add(this.lblApp);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnUsuarioPerfil
            // 
            this.btnUsuarioPerfil.Animated = true;
            this.btnUsuarioPerfil.BorderRadius = 12;
            this.btnUsuarioPerfil.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsuarioPerfil.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.btnUsuarioPerfil.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.btnUsuarioPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioPerfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnUsuarioPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioPerfil.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioPerfil.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.btnUsuarioPerfil.Location = new System.Drawing.Point(22, 232);
            this.btnUsuarioPerfil.Name = "btnUsuarioPerfil";
            this.btnUsuarioPerfil.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsuarioPerfil.Size = new System.Drawing.Size(196, 46);
            this.btnUsuarioPerfil.TabIndex = 4;
            this.btnUsuarioPerfil.Text = "Mi cuenta";
            this.btnUsuarioPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarioPerfil.Click += new System.EventHandler(this.btnUsuarioPerfil_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.Animated = true;
            this.btnContacto.BorderRadius = 12;
            this.btnContacto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnContacto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.btnContacto.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.btnContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnContacto.ForeColor = System.Drawing.Color.White;
            this.btnContacto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.btnContacto.Location = new System.Drawing.Point(22, 176);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnContacto.Size = new System.Drawing.Size(196, 46);
            this.btnContacto.TabIndex = 3;
            this.btnContacto.Text = "Contactos";
            this.btnContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Animated = true;
            this.btnPersonal.BorderRadius = 12;
            this.btnPersonal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPersonal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.btnPersonal.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnPersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.btnPersonal.Location = new System.Drawing.Point(22, 120);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPersonal.Size = new System.Drawing.Size(196, 46);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Mi ficha";
            this.btnPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.AutoSize = true;
            this.lblMenuTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.lblMenuTitulo.Location = new System.Drawing.Point(24, 86);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(57, 19);
            this.lblMenuTitulo.TabIndex = 1;
            this.lblMenuTitulo.Text = "Gestion";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblApp.ForeColor = System.Drawing.Color.White;
            this.lblApp.Location = new System.Drawing.Point(20, 27);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(186, 41);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Sistema ERP";
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 15;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1120, 700);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ERP - Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlRoot.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.cardInicio.ResumeLayout(false);
            this.cardInicio.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRoot;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnUsuarioPerfil;
        private Guna.UI2.WinForms.Guna2Button btnContacto;
        private Guna.UI2.WinForms.Guna2Button btnPersonal;
        private System.Windows.Forms.Label lblMenuTitulo;
        private System.Windows.Forms.Label lblApp;
        private Guna.UI2.WinForms.Guna2Panel pnlContenido;
        private Guna.UI2.WinForms.Guna2Panel pnlDatos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDatosTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlLinea;
        private Guna.UI2.WinForms.Guna2Panel cardInicio;
        private System.Windows.Forms.Label lblInicioTitulo;
        private System.Windows.Forms.Label lblInicioDetalle;
        private System.Windows.Forms.Timer fadeTimer;
    }
}
