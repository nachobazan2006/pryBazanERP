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
            this.pnlInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpCarga = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDato = new System.Windows.Forms.Label();
            this.txtDato = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.cmbUso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMedio = new System.Windows.Forms.Label();
            this.cmbMedio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblCargaTitulo = new System.Windows.Forms.Label();
            this.grpListado = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvContactos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblListadoTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInfo.SuspendLayout();
            this.grpCarga.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(34, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Contactos";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(39, 73);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(306, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Mail y telefono principal o de auxilio del personal";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.pnlInfo.BorderRadius = 12;
            this.pnlInfo.BorderThickness = 1;
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.pnlInfo.Location = new System.Drawing.Point(42, 108);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(707, 48);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblInfo.Location = new System.Drawing.Point(18, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(524, 17);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Un personal puede tener varios contactos: mail principal, telefono principal y au" +
    "xilios.";
            // 
            // grpCarga
            // 
            this.grpCarga.BackColor = System.Drawing.Color.Transparent;
            this.grpCarga.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.grpCarga.BorderRadius = 16;
            this.grpCarga.BorderThickness = 1;
            this.grpCarga.Controls.Add(this.lblDato);
            this.grpCarga.Controls.Add(this.txtDato);
            this.grpCarga.Controls.Add(this.lblUso);
            this.grpCarga.Controls.Add(this.cmbUso);
            this.grpCarga.Controls.Add(this.lblMedio);
            this.grpCarga.Controls.Add(this.cmbMedio);
            this.grpCarga.Controls.Add(this.lblPersona);
            this.grpCarga.Controls.Add(this.lblCargaTitulo);
            this.grpCarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.grpCarga.Location = new System.Drawing.Point(42, 176);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.grpCarga.ShadowDecoration.Depth = 8;
            this.grpCarga.ShadowDecoration.Enabled = true;
            this.grpCarga.Size = new System.Drawing.Size(330, 288);
            this.grpCarga.TabIndex = 3;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblDato.Location = new System.Drawing.Point(24, 203);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(33, 15);
            this.lblDato.TabIndex = 7;
            this.lblDato.Text = "Dato";
            // 
            // txtDato
            // 
            this.txtDato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtDato.BorderRadius = 12;
            this.txtDato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDato.DefaultText = "";
            this.txtDato.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtDato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtDato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtDato.Location = new System.Drawing.Point(26, 222);
            this.txtDato.Name = "txtDato";
            this.txtDato.PlaceholderText = "Mail o telefono";
            this.txtDato.SelectedText = "";
            this.txtDato.Size = new System.Drawing.Size(278, 36);
            this.txtDato.TabIndex = 8;
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblUso.Location = new System.Drawing.Point(24, 139);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(27, 15);
            this.lblUso.TabIndex = 5;
            this.lblUso.Text = "Uso";
            // 
            // cmbUso
            // 
            this.cmbUso.BackColor = System.Drawing.Color.Transparent;
            this.cmbUso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cmbUso.BorderRadius = 12;
            this.cmbUso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.cmbUso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.cmbUso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.cmbUso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.cmbUso.ItemHeight = 30;
            this.cmbUso.Location = new System.Drawing.Point(26, 158);
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(278, 36);
            this.cmbUso.TabIndex = 6;
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblMedio.Location = new System.Drawing.Point(24, 75);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(41, 15);
            this.lblMedio.TabIndex = 3;
            this.lblMedio.Text = "Medio";
            // 
            // cmbMedio
            // 
            this.cmbMedio.BackColor = System.Drawing.Color.Transparent;
            this.cmbMedio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cmbMedio.BorderRadius = 12;
            this.cmbMedio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.cmbMedio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.cmbMedio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.cmbMedio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.cmbMedio.ItemHeight = 30;
            this.cmbMedio.Location = new System.Drawing.Point(26, 94);
            this.cmbMedio.Name = "cmbMedio";
            this.cmbMedio.Size = new System.Drawing.Size(278, 36);
            this.cmbMedio.TabIndex = 4;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblPersona.Location = new System.Drawing.Point(24, 47);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(63, 17);
            this.lblPersona.TabIndex = 1;
            this.lblPersona.Text = "Personal:";
            // 
            // lblCargaTitulo
            // 
            this.lblCargaTitulo.AutoSize = true;
            this.lblCargaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCargaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblCargaTitulo.Location = new System.Drawing.Point(22, 18);
            this.lblCargaTitulo.Name = "lblCargaTitulo";
            this.lblCargaTitulo.Size = new System.Drawing.Size(127, 21);
            this.lblCargaTitulo.TabIndex = 0;
            this.lblCargaTitulo.Text = "Nuevo contacto";
            // 
            // grpListado
            // 
            this.grpListado.BackColor = System.Drawing.Color.Transparent;
            this.grpListado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.grpListado.BorderRadius = 16;
            this.grpListado.BorderThickness = 1;
            this.grpListado.Controls.Add(this.dgvContactos);
            this.grpListado.Controls.Add(this.lblListadoTitulo);
            this.grpListado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.grpListado.Location = new System.Drawing.Point(402, 176);
            this.grpListado.Name = "grpListado";
            this.grpListado.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.grpListado.ShadowDecoration.Depth = 8;
            this.grpListado.ShadowDecoration.Enabled = true;
            this.grpListado.Size = new System.Drawing.Size(347, 288);
            this.grpListado.TabIndex = 4;
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(3, 42);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(341, 234);
            this.dgvContactos.TabIndex = 1;
            // 
            // lblListadoTitulo
            // 
            this.lblListadoTitulo.AutoSize = true;
            this.lblListadoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblListadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblListadoTitulo.Location = new System.Drawing.Point(3, 18);
            this.lblListadoTitulo.Name = "lblListadoTitulo";
            this.lblListadoTitulo.Size = new System.Drawing.Size(155, 21);
            this.lblListadoTitulo.TabIndex = 0;
            this.lblListadoTitulo.Text = "Contactos cargados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.btnGuardar.Location = new System.Drawing.Point(252, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpCarga);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Contactos";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
        private Guna.UI2.WinForms.Guna2Panel grpCarga;
        private System.Windows.Forms.Label lblCargaTitulo;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblMedio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMedio;
        private System.Windows.Forms.Label lblUso;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUso;
        private System.Windows.Forms.Label lblDato;
        private Guna.UI2.WinForms.Guna2TextBox txtDato;
        private Guna.UI2.WinForms.Guna2Panel grpListado;
        private System.Windows.Forms.Label lblListadoTitulo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvContactos;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
    }
}
