namespace pryBazanERP.Formulario
{
    partial class frmUsuarioPerfil
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
            this.grpCambio = new Guna.UI2.WinForms.Guna2Panel();
            this.txtConfirmar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtNueva = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtActual = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblCambioTitulo = new System.Windows.Forms.Label();
            this.chkMostrarContrasenas = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarCambio = new Guna.UI2.WinForms.Guna2Button();
            this.grpCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblTitulo.Location = new System.Drawing.Point(34, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi cuenta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 92, 64);
            this.lblSubtitulo.Location = new System.Drawing.Point(39, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(252, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Datos de usuario, perfil y contrasena de acceso";
            // 
            // grpCambio
            // 
            this.grpCambio.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.grpCambio.BorderRadius = 16;
            this.grpCambio.BorderThickness = 1;
            this.grpCambio.Controls.Add(this.btnLimpiarCambio);
            this.grpCambio.Controls.Add(this.txtConfirmar);
            this.grpCambio.Controls.Add(this.lblConfirmar);
            this.grpCambio.Controls.Add(this.txtNueva);
            this.grpCambio.Controls.Add(this.lblNueva);
            this.grpCambio.Controls.Add(this.txtActual);
            this.grpCambio.Controls.Add(this.lblActual);
            this.grpCambio.Controls.Add(this.chkMostrarContrasenas);
            this.grpCambio.Controls.Add(this.lblCambioTitulo);
            this.grpCambio.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.grpCambio.Location = new System.Drawing.Point(42, 120);
            this.grpCambio.Name = "grpCambio";
            this.grpCambio.ShadowDecoration.Color = System.Drawing.Color.FromArgb(120, 92, 64);
            this.grpCambio.ShadowDecoration.Depth = 8;
            this.grpCambio.ShadowDecoration.Enabled = true;
            this.grpCambio.Size = new System.Drawing.Size(330, 322);
            this.grpCambio.TabIndex = 2;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtConfirmar.BorderRadius = 12;
            this.txtConfirmar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmar.DefaultText = "";
            this.txtConfirmar.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtConfirmar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmar.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtConfirmar.Location = new System.Drawing.Point(26, 222);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.PlaceholderText = "Confirmar contrasena";
            this.txtConfirmar.SelectedText = "";
            this.txtConfirmar.Size = new System.Drawing.Size(278, 36);
            this.txtConfirmar.TabIndex = 6;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblConfirmar.Location = new System.Drawing.Point(24, 203);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(122, 15);
            this.lblConfirmar.TabIndex = 5;
            this.lblConfirmar.Text = "Confirmar contrasena";
            // 
            // txtNueva
            // 
            this.txtNueva.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtNueva.BorderRadius = 12;
            this.txtNueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNueva.DefaultText = "";
            this.txtNueva.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtNueva.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtNueva.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNueva.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtNueva.Location = new System.Drawing.Point(26, 158);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.PlaceholderText = "Nueva contrasena";
            this.txtNueva.SelectedText = "";
            this.txtNueva.Size = new System.Drawing.Size(278, 36);
            this.txtNueva.TabIndex = 4;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNueva.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblNueva.Location = new System.Drawing.Point(24, 139);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(105, 15);
            this.lblNueva.TabIndex = 3;
            this.lblNueva.Text = "Nueva contrasena";
            // 
            // txtActual
            // 
            this.txtActual.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtActual.BorderRadius = 12;
            this.txtActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActual.DefaultText = "";
            this.txtActual.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtActual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtActual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActual.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtActual.Location = new System.Drawing.Point(26, 94);
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.PlaceholderText = "Contrasena actual";
            this.txtActual.SelectedText = "";
            this.txtActual.Size = new System.Drawing.Size(278, 36);
            this.txtActual.TabIndex = 2;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblActual.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblActual.Location = new System.Drawing.Point(24, 75);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(104, 15);
            this.lblActual.TabIndex = 1;
            this.lblActual.Text = "Contrasena actual";
            // 
            // lblCambioTitulo
            // 
            this.lblCambioTitulo.AutoSize = true;
            this.lblCambioTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCambioTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblCambioTitulo.Location = new System.Drawing.Point(22, 18);
            this.lblCambioTitulo.Name = "lblCambioTitulo";
            this.lblCambioTitulo.Size = new System.Drawing.Size(176, 21);
            this.lblCambioTitulo.TabIndex = 0;
            this.lblCambioTitulo.Text = "Cambiar contrasena";
            // 
            // chkMostrarContrasenas
            // 
            this.chkMostrarContrasenas.AutoSize = true;
            this.chkMostrarContrasenas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.chkMostrarContrasenas.CheckedState.BorderRadius = 3;
            this.chkMostrarContrasenas.CheckedState.BorderThickness = 0;
            this.chkMostrarContrasenas.CheckedState.FillColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.chkMostrarContrasenas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkMostrarContrasenas.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.chkMostrarContrasenas.Location = new System.Drawing.Point(26, 270);
            this.chkMostrarContrasenas.Name = "chkMostrarContrasenas";
            this.chkMostrarContrasenas.Size = new System.Drawing.Size(133, 19);
            this.chkMostrarContrasenas.TabIndex = 7;
            this.chkMostrarContrasenas.Text = "Mostrar contrasenas";
            this.chkMostrarContrasenas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.chkMostrarContrasenas.UncheckedState.BorderRadius = 3;
            this.chkMostrarContrasenas.UncheckedState.BorderThickness = 0;
            this.chkMostrarContrasenas.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.chkMostrarContrasenas.CheckedChanged += new System.EventHandler(this.chkMostrarContrasenas_CheckedChanged);
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
            this.btnGuardar.Location = new System.Drawing.Point(252, 470);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiarCambio
            // 
            this.btnLimpiarCambio.Animated = true;
            this.btnLimpiarCambio.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.btnLimpiarCambio.BorderRadius = 8;
            this.btnLimpiarCambio.BorderThickness = 1;
            this.btnLimpiarCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCambio.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.btnLimpiarCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCambio.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.btnLimpiarCambio.HoverState.FillColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.btnLimpiarCambio.Location = new System.Drawing.Point(219, 18);
            this.btnLimpiarCambio.Name = "btnLimpiarCambio";
            this.btnLimpiarCambio.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarCambio.TabIndex = 8;
            this.btnLimpiarCambio.Text = "Limpiar";
            this.btnLimpiarCambio.Click += new System.EventHandler(this.btnLimpiarCambio_Click);
            // 
            // frmUsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(232, 218, 198);
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpCambio);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Mi cuenta";
            this.grpCambio.ResumeLayout(false);
            this.grpCambio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel grpCambio;
        private System.Windows.Forms.Label lblCambioTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtActual;
        private System.Windows.Forms.Label lblActual;
        private Guna.UI2.WinForms.Guna2TextBox txtNueva;
        private System.Windows.Forms.Label lblNueva;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private Guna.UI2.WinForms.Guna2CheckBox chkMostrarContrasenas;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarCambio;
    }
}
