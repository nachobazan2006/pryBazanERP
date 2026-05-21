namespace pryBazanERP
{
    partial class frmERP
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

        #region Codigo generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlShell = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaDetalle = new System.Windows.Forms.Label();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.chkOcultarContraseña = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlEstado = new Guna.UI2.WinForms.Guna2Panel();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlShell.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShell
            // 
            this.pnlShell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlShell.Controls.Add(this.lblMarca);
            this.pnlShell.Controls.Add(this.lblMarcaDetalle);
            this.pnlShell.Controls.Add(this.pnlCard);
            this.pnlShell.Controls.Add(this.lblEstado);
            this.pnlShell.Controls.Add(this.pnlEstado);
            this.pnlShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShell.Location = new System.Drawing.Point(0, 0);
            this.pnlShell.Name = "pnlShell";
            this.pnlShell.Size = new System.Drawing.Size(900, 520);
            this.pnlShell.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblMarca.Location = new System.Drawing.Point(80, 148);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(272, 47);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Sistema gestión";
            // 
            // lblMarcaDetalle
            // 
            this.lblMarcaDetalle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMarcaDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblMarcaDetalle.Location = new System.Drawing.Point(86, 204);
            this.lblMarcaDetalle.Name = "lblMarcaDetalle";
            this.lblMarcaDetalle.Size = new System.Drawing.Size(296, 78);
            this.lblMarcaDetalle.TabIndex = 1;
            this.lblMarcaDetalle.Text = "Gestion interna de personal, contactos y perfiles con datos locales en Access.";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.pnlCard.BorderRadius = 8;
            this.pnlCard.BorderThickness = 1;
            this.pnlCard.Controls.Add(this.chkOcultarContraseña);
            this.pnlCard.Controls.Add(this.lblSubtitulo);
            this.pnlCard.Controls.Add(this.lblTitulo);
            this.pnlCard.Controls.Add(this.btnIngresar);
            this.pnlCard.Controls.Add(this.txtContraseña);
            this.pnlCard.Controls.Add(this.txtUsuario);
            this.pnlCard.Controls.Add(this.lblContraseña);
            this.pnlCard.Controls.Add(this.lblUsuario);
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.pnlCard.Location = new System.Drawing.Point(490, 72);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.pnlCard.ShadowDecoration.Depth = 16;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 5, 14, 14);
            this.pnlCard.Size = new System.Drawing.Size(330, 376);
            this.pnlCard.TabIndex = 2;
            // 
            // chkOcultarContraseña
            // 
            this.chkOcultarContraseña.AutoSize = true;
            this.chkOcultarContraseña.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.chkOcultarContraseña.CheckedState.BorderRadius = 2;
            this.chkOcultarContraseña.CheckedState.BorderThickness = 0;
            this.chkOcultarContraseña.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.chkOcultarContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkOcultarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.chkOcultarContraseña.Location = new System.Drawing.Point(42, 265);
            this.chkOcultarContraseña.Name = "chkOcultarContraseña";
            this.chkOcultarContraseña.Size = new System.Drawing.Size(128, 19);
            this.chkOcultarContraseña.TabIndex = 4;
            this.chkOcultarContraseña.Text = "Mostrar contraseña";
            this.chkOcultarContraseña.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.chkOcultarContraseña.UncheckedState.BorderRadius = 2;
            this.chkOcultarContraseña.UncheckedState.BorderThickness = 0;
            this.chkOcultarContraseña.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.chkOcultarContraseña.CheckedChanged += new System.EventHandler(this.chkOcultarContraseña_CheckedChanged);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 79);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(176, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Ingresa tus datos para continuar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(36, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Iniciar sesion";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Animated = true;
            this.btnIngresar.BorderRadius = 6;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.btnIngresar.Location = new System.Drawing.Point(42, 306);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(246, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtContraseña.BorderRadius = 6;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtContraseña.Location = new System.Drawing.Point(42, 226);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.txtContraseña.PlaceholderText = "Clave";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.Size = new System.Drawing.Size(246, 34);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtUsuario.BorderRadius = 6;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtUsuario.Location = new System.Drawing.Point(42, 150);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.txtUsuario.PlaceholderText = "Correo o usuario";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(246, 34);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblContraseña.Location = new System.Drawing.Point(40, 205);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(66, 15);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblUsuario.Location = new System.Drawing.Point(40, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario / correo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblEstado.Location = new System.Drawing.Point(38, 468);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(110, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado de conexion";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // pnlEstado
            // 
            this.pnlEstado.BorderRadius = 4;
            this.pnlEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.pnlEstado.Location = new System.Drawing.Point(25, 471);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(8, 8);
            this.pnlEstado.TabIndex = 3;
            // 
            // loginTimer
            // 
            this.loginTimer.Interval = 15;
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);
            // 
            // frmERP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.pnlShell);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmERP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bazan ERP - Login";
            this.Load += new System.EventHandler(this.frmERP_Load);
            this.pnlShell.ResumeLayout(false);
            this.pnlShell.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlShell;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaDetalle;
        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlEstado;
        private Guna.UI2.WinForms.Guna2CheckBox chkOcultarContraseña;
        private System.Windows.Forms.Timer loginTimer;
    }
}
