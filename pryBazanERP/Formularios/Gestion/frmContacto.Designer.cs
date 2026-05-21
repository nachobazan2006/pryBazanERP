namespace pryBazanERP.Formulario
{
    partial class frmContacto
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

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpContacto = new Guna.UI2.WinForms.Guna2Panel();
            this.chkActivo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmbPersonal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblContactoTitulo = new System.Windows.Forms.Label();
            this.grpRedes = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTwitter = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.txtFacebook = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtInstagram = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.lblRedesTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.grpContacto.SuspendLayout();
            this.grpRedes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblTitulo.Location = new System.Drawing.Point(34, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Contacto";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 92, 64);
            this.lblSubtitulo.Location = new System.Drawing.Point(39, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(322, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Mail, telefono y redes asociadas a cada personal";
            // 
            // grpContacto
            // 
            this.grpContacto.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.grpContacto.BorderRadius = 16;
            this.grpContacto.BorderThickness = 1;
            this.grpContacto.Controls.Add(this.chkActivo);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Controls.Add(this.cmbPersonal);
            this.grpContacto.Controls.Add(this.lblPersonal);
            this.grpContacto.Controls.Add(this.lblContactoTitulo);
            this.grpContacto.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.grpContacto.Location = new System.Drawing.Point(40, 118);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.ShadowDecoration.Color = System.Drawing.Color.FromArgb(120, 92, 64);
            this.grpContacto.ShadowDecoration.Depth = 8;
            this.grpContacto.ShadowDecoration.Enabled = true;
            this.grpContacto.Size = new System.Drawing.Size(330, 288);
            this.grpContacto.TabIndex = 2;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.chkActivo.CheckedState.BorderRadius = 3;
            this.chkActivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkActivo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.chkActivo.Location = new System.Drawing.Point(26, 244);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 21);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.chkActivo.UncheckedState.BorderRadius = 3;
            this.chkActivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtTelefono.BorderRadius = 12;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtTelefono.Location = new System.Drawing.Point(26, 199);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Telefono";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(278, 36);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblTelefono.Location = new System.Drawing.Point(24, 180);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtMail.BorderRadius = 12;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtMail.Location = new System.Drawing.Point(26, 135);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "Mail";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(278, 36);
            this.txtMail.TabIndex = 4;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblMail.Location = new System.Drawing.Point(24, 116);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(30, 15);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.Color.Transparent;
            this.cmbPersonal.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.cmbPersonal.BorderRadius = 12;
            this.cmbPersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.cmbPersonal.FocusedColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.cmbPersonal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.cmbPersonal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPersonal.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.cmbPersonal.ItemHeight = 30;
            this.cmbPersonal.Location = new System.Drawing.Point(26, 72);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(278, 36);
            this.cmbPersonal.TabIndex = 2;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonal.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblPersonal.Location = new System.Drawing.Point(24, 53);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(52, 15);
            this.lblPersonal.TabIndex = 1;
            this.lblPersonal.Text = "Personal";
            // 
            // lblContactoTitulo
            // 
            this.lblContactoTitulo.AutoSize = true;
            this.lblContactoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactoTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblContactoTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblContactoTitulo.Name = "lblContactoTitulo";
            this.lblContactoTitulo.Size = new System.Drawing.Size(76, 21);
            this.lblContactoTitulo.TabIndex = 0;
            this.lblContactoTitulo.Text = "Contacto";
            // 
            // grpRedes
            // 
            this.grpRedes.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.grpRedes.BorderRadius = 16;
            this.grpRedes.BorderThickness = 1;
            this.grpRedes.Controls.Add(this.txtTwitter);
            this.grpRedes.Controls.Add(this.lblTwitter);
            this.grpRedes.Controls.Add(this.txtFacebook);
            this.grpRedes.Controls.Add(this.lblFacebook);
            this.grpRedes.Controls.Add(this.txtInstagram);
            this.grpRedes.Controls.Add(this.lblInstagram);
            this.grpRedes.Controls.Add(this.lblRedesTitulo);
            this.grpRedes.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.grpRedes.Location = new System.Drawing.Point(402, 118);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.ShadowDecoration.Color = System.Drawing.Color.FromArgb(120, 92, 64);
            this.grpRedes.ShadowDecoration.Depth = 8;
            this.grpRedes.ShadowDecoration.Enabled = true;
            this.grpRedes.Size = new System.Drawing.Size(330, 288);
            this.grpRedes.TabIndex = 3;
            // 
            // txtTwitter
            // 
            this.txtTwitter.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtTwitter.BorderRadius = 12;
            this.txtTwitter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTwitter.DefaultText = "";
            this.txtTwitter.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtTwitter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtTwitter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTwitter.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtTwitter.Location = new System.Drawing.Point(26, 199);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.PasswordChar = '\0';
            this.txtTwitter.PlaceholderText = "Twitter";
            this.txtTwitter.SelectedText = "";
            this.txtTwitter.Size = new System.Drawing.Size(278, 36);
            this.txtTwitter.TabIndex = 6;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTwitter.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblTwitter.Location = new System.Drawing.Point(24, 180);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(44, 15);
            this.lblTwitter.TabIndex = 5;
            this.lblTwitter.Text = "Twitter";
            // 
            // txtFacebook
            // 
            this.txtFacebook.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtFacebook.BorderRadius = 12;
            this.txtFacebook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFacebook.DefaultText = "";
            this.txtFacebook.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtFacebook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtFacebook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacebook.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtFacebook.Location = new System.Drawing.Point(26, 135);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.PasswordChar = '\0';
            this.txtFacebook.PlaceholderText = "Facebook";
            this.txtFacebook.SelectedText = "";
            this.txtFacebook.Size = new System.Drawing.Size(278, 36);
            this.txtFacebook.TabIndex = 4;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblFacebook.Location = new System.Drawing.Point(24, 116);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(57, 15);
            this.lblFacebook.TabIndex = 3;
            this.lblFacebook.Text = "Facebook";
            // 
            // txtInstagram
            // 
            this.txtInstagram.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtInstagram.BorderRadius = 12;
            this.txtInstagram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstagram.DefaultText = "";
            this.txtInstagram.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtInstagram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtInstagram.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInstagram.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtInstagram.Location = new System.Drawing.Point(26, 72);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.PasswordChar = '\0';
            this.txtInstagram.PlaceholderText = "Instagram";
            this.txtInstagram.SelectedText = "";
            this.txtInstagram.Size = new System.Drawing.Size(278, 36);
            this.txtInstagram.TabIndex = 2;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstagram.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblInstagram.Location = new System.Drawing.Point(24, 53);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(62, 15);
            this.lblInstagram.TabIndex = 1;
            this.lblInstagram.Text = "Instagram";
            // 
            // lblRedesTitulo
            // 
            this.lblRedesTitulo.AutoSize = true;
            this.lblRedesTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRedesTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblRedesTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblRedesTitulo.Name = "lblRedesTitulo";
            this.lblRedesTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblRedesTitulo.TabIndex = 0;
            this.lblRedesTitulo.Text = "Redes";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.btnGuardar.Location = new System.Drawing.Point(252, 438);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Animated = true;
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.btnLimpiar.BorderRadius = 12;
            this.btnLimpiar.BorderThickness = 1;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.btnLimpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.btnLimpiar.Location = new System.Drawing.Point(408, 438);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 42);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(232, 218, 198);
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpRedes);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Contacto";
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel grpContacto;
        private Guna.UI2.WinForms.Guna2CheckBox chkActivo;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPersonal;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblContactoTitulo;
        private Guna.UI2.WinForms.Guna2Panel grpRedes;
        private Guna.UI2.WinForms.Guna2TextBox txtTwitter;
        private System.Windows.Forms.Label lblTwitter;
        private Guna.UI2.WinForms.Guna2TextBox txtFacebook;
        private System.Windows.Forms.Label lblFacebook;
        private Guna.UI2.WinForms.Guna2TextBox txtInstagram;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.Label lblRedesTitulo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
    }
}
