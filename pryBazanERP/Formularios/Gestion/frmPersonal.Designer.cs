namespace pryBazanERP.Formulario
{
    partial class frmPersonal
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
            this.grpDatos = new Guna.UI2.WinForms.Guna2Panel();
            this.chkActivo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDatosTitulo = new System.Windows.Forms.Label();
            this.grpDomicilio = new Guna.UI2.WinForms.Guna2Panel();
            this.lstLocalidades = new System.Windows.Forms.ListBox();
            this.lstProvincias = new System.Windows.Forms.ListBox();
            this.txtLocalidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtProvincia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtGeo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGeo = new System.Windows.Forms.Label();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDomicilioTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarDatos = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarDomicilio = new Guna.UI2.WinForms.Guna2Button();
            this.grpDatos.SuspendLayout();
            this.grpDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblTitulo.Location = new System.Drawing.Point(34, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Personal";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 92, 64);
            this.lblSubtitulo.Location = new System.Drawing.Point(39, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(223, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Alta de datos personales y domicilio";
            // 
            // grpDatos
            // 
            this.grpDatos.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.grpDatos.BorderRadius = 16;
            this.grpDatos.BorderThickness = 1;
            this.grpDatos.Controls.Add(this.btnLimpiarDatos);
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.lblDni);
            this.grpDatos.Controls.Add(this.lblDatosTitulo);
            this.grpDatos.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.grpDatos.Location = new System.Drawing.Point(40, 118);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(120, 92, 64);
            this.grpDatos.ShadowDecoration.Depth = 8;
            this.grpDatos.ShadowDecoration.Enabled = true;
            this.grpDatos.Size = new System.Drawing.Size(330, 288);
            this.grpDatos.TabIndex = 2;
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
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtNombre.Location = new System.Drawing.Point(26, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(278, 36);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblNombre.Location = new System.Drawing.Point(24, 180);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtApellido.BorderRadius = 12;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtApellido.Location = new System.Drawing.Point(26, 135);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(278, 36);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblApellido.Location = new System.Drawing.Point(24, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtDni.BorderRadius = 12;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtDni.Location = new System.Drawing.Point(26, 72);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(278, 36);
            this.txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblDni.Location = new System.Drawing.Point(24, 53);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblDatosTitulo
            // 
            this.lblDatosTitulo.AutoSize = true;
            this.lblDatosTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblDatosTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblDatosTitulo.Name = "lblDatosTitulo";
            this.lblDatosTitulo.Size = new System.Drawing.Size(141, 21);
            this.lblDatosTitulo.TabIndex = 0;
            this.lblDatosTitulo.Text = "Datos personales";
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.grpDomicilio.BorderRadius = 16;
            this.grpDomicilio.BorderThickness = 1;
            this.grpDomicilio.Controls.Add(this.btnLimpiarDomicilio);
            this.grpDomicilio.Controls.Add(this.lstLocalidades);
            this.grpDomicilio.Controls.Add(this.lstProvincias);
            this.grpDomicilio.Controls.Add(this.txtLocalidad);
            this.grpDomicilio.Controls.Add(this.lblLocalidad);
            this.grpDomicilio.Controls.Add(this.txtProvincia);
            this.grpDomicilio.Controls.Add(this.lblProvincia);
            this.grpDomicilio.Controls.Add(this.txtGeo);
            this.grpDomicilio.Controls.Add(this.lblGeo);
            this.grpDomicilio.Controls.Add(this.txtDireccion);
            this.grpDomicilio.Controls.Add(this.lblDireccion);
            this.grpDomicilio.Controls.Add(this.lblDomicilioTitulo);
            this.grpDomicilio.FillColor = System.Drawing.Color.FromArgb(246, 238, 226);
            this.grpDomicilio.Location = new System.Drawing.Point(402, 118);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.ShadowDecoration.Color = System.Drawing.Color.FromArgb(120, 92, 64);
            this.grpDomicilio.ShadowDecoration.Depth = 8;
            this.grpDomicilio.ShadowDecoration.Enabled = true;
            this.grpDomicilio.Size = new System.Drawing.Size(330, 360);
            this.grpDomicilio.TabIndex = 3;
            // 
            // lstLocalidades
            // 
            this.lstLocalidades.BackColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.lstLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLocalidades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstLocalidades.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lstLocalidades.FormattingEnabled = true;
            this.lstLocalidades.ItemHeight = 15;
            this.lstLocalidades.Location = new System.Drawing.Point(26, 300);
            this.lstLocalidades.Name = "lstLocalidades";
            this.lstLocalidades.Size = new System.Drawing.Size(278, 47);
            this.lstLocalidades.TabIndex = 10;
            this.lstLocalidades.Visible = false;
            this.lstLocalidades.Click += new System.EventHandler(this.lstLocalidades_Click);
            this.lstLocalidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLocalidades_KeyDown);
            this.lstLocalidades.Leave += new System.EventHandler(this.lstLocalidades_Leave);
            // 
            // lstProvincias
            // 
            this.lstProvincias.BackColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.lstProvincias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProvincias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstProvincias.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lstProvincias.FormattingEnabled = true;
            this.lstProvincias.ItemHeight = 15;
            this.lstProvincias.Location = new System.Drawing.Point(26, 109);
            this.lstProvincias.Name = "lstProvincias";
            this.lstProvincias.Size = new System.Drawing.Size(278, 62);
            this.lstProvincias.TabIndex = 3;
            this.lstProvincias.Visible = false;
            this.lstProvincias.Click += new System.EventHandler(this.lstProvincias_Click);
            this.lstProvincias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProvincias_KeyDown);
            this.lstProvincias.Leave += new System.EventHandler(this.lstProvincias_Leave);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtLocalidad.BorderRadius = 12;
            this.txtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalidad.DefaultText = "";
            this.txtLocalidad.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtLocalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtLocalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtLocalidad.Location = new System.Drawing.Point(26, 264);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PasswordChar = '\0';
            this.txtLocalidad.PlaceholderText = "Escriba para buscar";
            this.txtLocalidad.SelectedText = "";
            this.txtLocalidad.Size = new System.Drawing.Size(278, 36);
            this.txtLocalidad.TabIndex = 9;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txtLocalidad_TextChanged);
            this.txtLocalidad.Leave += new System.EventHandler(this.txtLocalidad_Leave);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblLocalidad.Location = new System.Drawing.Point(24, 245);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(58, 15);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtProvincia
            // 
            this.txtProvincia.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtProvincia.BorderRadius = 12;
            this.txtProvincia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvincia.DefaultText = "";
            this.txtProvincia.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtProvincia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtProvincia.Location = new System.Drawing.Point(26, 72);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.PasswordChar = '\0';
            this.txtProvincia.PlaceholderText = "Provincia";
            this.txtProvincia.SelectedText = "";
            this.txtProvincia.Size = new System.Drawing.Size(278, 36);
            this.txtProvincia.TabIndex = 2;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            this.txtProvincia.Enter += new System.EventHandler(this.txtProvincia_Enter);
            this.txtProvincia.Leave += new System.EventHandler(this.txtProvincia_Leave);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblProvincia.Location = new System.Drawing.Point(24, 53);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtGeo
            // 
            this.txtGeo.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtGeo.BorderRadius = 12;
            this.txtGeo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeo.DefaultText = "";
            this.txtGeo.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtGeo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtGeo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGeo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtGeo.Location = new System.Drawing.Point(26, 202);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.PasswordChar = '\0';
            this.txtGeo.PlaceholderText = "Geo / Google";
            this.txtGeo.SelectedText = "";
            this.txtGeo.Size = new System.Drawing.Size(278, 36);
            this.txtGeo.TabIndex = 7;
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGeo.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblGeo.Location = new System.Drawing.Point(24, 183);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(85, 15);
            this.lblGeo.TabIndex = 6;
            this.lblGeo.Text = "Geo / Google";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.txtDireccion.BorderRadius = 12;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(111, 74, 45);
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.txtDireccion.Location = new System.Drawing.Point(26, 140);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderText = "Direccion";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(278, 36);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.lblDireccion.Location = new System.Drawing.Point(24, 121);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblDomicilioTitulo
            // 
            this.lblDomicilioTitulo.AutoSize = true;
            this.lblDomicilioTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDomicilioTitulo.ForeColor = System.Drawing.Color.FromArgb(72, 48, 34);
            this.lblDomicilioTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblDomicilioTitulo.Name = "lblDomicilioTitulo";
            this.lblDomicilioTitulo.Size = new System.Drawing.Size(80, 21);
            this.lblDomicilioTitulo.TabIndex = 0;
            this.lblDomicilioTitulo.Text = "Domicilio";
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
            this.btnGuardar.Location = new System.Drawing.Point(252, 508);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Animated = true;
            this.btnLimpiarDatos.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.btnLimpiarDatos.BorderRadius = 8;
            this.btnLimpiarDatos.BorderThickness = 1;
            this.btnLimpiarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatos.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.btnLimpiarDatos.HoverState.FillColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.btnLimpiarDatos.Location = new System.Drawing.Point(219, 18);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarDatos.TabIndex = 8;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnLimpiarDomicilio
            // 
            this.btnLimpiarDomicilio.Animated = true;
            this.btnLimpiarDomicilio.BorderColor = System.Drawing.Color.FromArgb(150, 111, 76);
            this.btnLimpiarDomicilio.BorderRadius = 8;
            this.btnLimpiarDomicilio.BorderThickness = 1;
            this.btnLimpiarDomicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDomicilio.FillColor = System.Drawing.Color.FromArgb(255, 250, 243);
            this.btnLimpiarDomicilio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDomicilio.ForeColor = System.Drawing.Color.FromArgb(84, 60, 42);
            this.btnLimpiarDomicilio.HoverState.FillColor = System.Drawing.Color.FromArgb(218, 198, 174);
            this.btnLimpiarDomicilio.Location = new System.Drawing.Point(219, 18);
            this.btnLimpiarDomicilio.Name = "btnLimpiarDomicilio";
            this.btnLimpiarDomicilio.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarDomicilio.TabIndex = 11;
            this.btnLimpiarDomicilio.Text = "Limpiar";
            this.btnLimpiarDomicilio.Click += new System.EventHandler(this.btnLimpiarDomicilio_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(232, 218, 198);
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDomicilio);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Personal";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel grpDatos;
        private Guna.UI2.WinForms.Guna2CheckBox chkActivo;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDatosTitulo;
        private Guna.UI2.WinForms.Guna2Panel grpDomicilio;
        private System.Windows.Forms.ListBox lstLocalidades;
        private System.Windows.Forms.ListBox lstProvincias;
        private Guna.UI2.WinForms.Guna2TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private Guna.UI2.WinForms.Guna2TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private Guna.UI2.WinForms.Guna2TextBox txtGeo;
        private System.Windows.Forms.Label lblGeo;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDomicilioTitulo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarDatos;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarDomicilio;
    }
}
