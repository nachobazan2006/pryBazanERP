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
            this.btnLimpiarDatos = new Guna.UI2.WinForms.Guna2Button();
            this.chkActivo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDatosTitulo = new System.Windows.Forms.Label();
            this.grpDomicilio = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLimpiarDomicilio = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblIconoTitulo = new System.Windows.Forms.Label();
            this.lineaTitulo = new System.Windows.Forms.Panel();
            this.grpDatosCargados = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlResumenDomicilio = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResumenDomGeoValor = new System.Windows.Forms.Label();
            this.lblResumenDomGeo = new System.Windows.Forms.Label();
            this.pnlResumenEstado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResumenEstadoValor = new System.Windows.Forms.Label();
            this.lblResumenEstado = new System.Windows.Forms.Label();
            this.lblResumenDomProvinciaValor = new System.Windows.Forms.Label();
            this.lblResumenDomProvincia = new System.Windows.Forms.Label();
            this.lblResumenDomLocalidadValor = new System.Windows.Forms.Label();
            this.lblResumenDomLocalidad = new System.Windows.Forms.Label();
            this.lblResumenDomDireccionValor = new System.Windows.Forms.Label();
            this.lblResumenDomDireccion = new System.Windows.Forms.Label();
            this.lblResumenDomTitulo = new System.Windows.Forms.Label();
            this.lblResumenDomIcono = new System.Windows.Forms.Label();
            this.pnlResumenDatos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResumenNombreValor = new System.Windows.Forms.Label();
            this.lblResumenNombre = new System.Windows.Forms.Label();
            this.lblResumenApellidoValor = new System.Windows.Forms.Label();
            this.lblResumenApellido = new System.Windows.Forms.Label();
            this.lblResumenDniValor = new System.Windows.Forms.Label();
            this.lblResumenDni = new System.Windows.Forms.Label();
            this.lblResumenDatosTitulo = new System.Windows.Forms.Label();
            this.lblResumenDatosIcono = new System.Windows.Forms.Label();
            this.pnlResumenActualizado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResumenActualizado = new System.Windows.Forms.Label();
            this.lblResumenRefreshIcono = new System.Windows.Forms.Label();
            this.lblResumenSubtitulo = new System.Windows.Forms.Label();
            this.lblResumenTitulo = new System.Windows.Forms.Label();
            this.lblResumenIcono = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.grpDomicilio.SuspendLayout();
            this.grpDatosCargados.SuspendLayout();
            this.pnlResumenDomicilio.SuspendLayout();
            this.pnlResumenEstado.SuspendLayout();
            this.pnlResumenDatos.SuspendLayout();
            this.pnlResumenActualizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(82, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(137, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi ficha";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(84, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(294, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Datos personales y domicilio del usuario actual";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
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
            this.grpDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.grpDatos.Location = new System.Drawing.Point(40, 388);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.grpDatos.ShadowDecoration.Depth = 8;
            this.grpDatos.ShadowDecoration.Enabled = true;
            this.grpDatos.Size = new System.Drawing.Size(330, 360);
            this.grpDatos.TabIndex = 2;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Animated = true;
            this.btnLimpiarDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.btnLimpiarDatos.BorderRadius = 8;
            this.btnLimpiarDatos.BorderThickness = 1;
            this.btnLimpiarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.btnLimpiarDatos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(219, 18);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarDatos.TabIndex = 8;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.chkActivo.CheckedState.BorderRadius = 3;
            this.chkActivo.CheckedState.BorderThickness = 0;
            this.chkActivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.chkActivo.Location = new System.Drawing.Point(26, 326);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 21);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.chkActivo.UncheckedState.BorderRadius = 3;
            this.chkActivo.UncheckedState.BorderThickness = 0;
            this.chkActivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtNombre.Location = new System.Drawing.Point(26, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(278, 36);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(24, 180);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtApellido.BorderRadius = 12;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtApellido.Location = new System.Drawing.Point(26, 135);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(278, 36);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblApellido.Location = new System.Drawing.Point(24, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtDni.BorderRadius = 12;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtDni.Location = new System.Drawing.Point(26, 72);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(278, 36);
            this.txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblDni.Location = new System.Drawing.Point(24, 53);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 15);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblDatosTitulo
            // 
            this.lblDatosTitulo.AutoSize = true;
            this.lblDatosTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblDatosTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblDatosTitulo.Name = "lblDatosTitulo";
            this.lblDatosTitulo.Size = new System.Drawing.Size(135, 21);
            this.lblDatosTitulo.TabIndex = 0;
            this.lblDatosTitulo.Text = "Datos personales";
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.grpDomicilio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
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
            this.grpDomicilio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.grpDomicilio.Location = new System.Drawing.Point(402, 388);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.grpDomicilio.ShadowDecoration.Depth = 8;
            this.grpDomicilio.ShadowDecoration.Enabled = true;
            this.grpDomicilio.Size = new System.Drawing.Size(330, 360);
            this.grpDomicilio.TabIndex = 3;
            // 
            // btnLimpiarDomicilio
            // 
            this.btnLimpiarDomicilio.Animated = true;
            this.btnLimpiarDomicilio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(76)))));
            this.btnLimpiarDomicilio.BorderRadius = 8;
            this.btnLimpiarDomicilio.BorderThickness = 1;
            this.btnLimpiarDomicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDomicilio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.btnLimpiarDomicilio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.btnLimpiarDomicilio.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.btnLimpiarDomicilio.Location = new System.Drawing.Point(219, 18);
            this.btnLimpiarDomicilio.Name = "btnLimpiarDomicilio";
            this.btnLimpiarDomicilio.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarDomicilio.TabIndex = 11;
            this.btnLimpiarDomicilio.Text = "Limpiar";
            this.btnLimpiarDomicilio.Click += new System.EventHandler(this.btnLimpiarDomicilio_Click);
            // 
            // lstLocalidades
            // 
            this.lstLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.lstLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLocalidades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstLocalidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
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
            this.lstProvincias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.lstProvincias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProvincias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstProvincias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
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
            this.txtLocalidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtLocalidad.BorderRadius = 12;
            this.txtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalidad.DefaultText = "";
            this.txtLocalidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtLocalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtLocalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtLocalidad.Location = new System.Drawing.Point(26, 264);
            this.txtLocalidad.Name = "txtLocalidad";
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
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblLocalidad.Location = new System.Drawing.Point(24, 245);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(58, 15);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtProvincia
            // 
            this.txtProvincia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtProvincia.BorderRadius = 12;
            this.txtProvincia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvincia.DefaultText = "";
            this.txtProvincia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtProvincia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtProvincia.Location = new System.Drawing.Point(26, 72);
            this.txtProvincia.Name = "txtProvincia";
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
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblProvincia.Location = new System.Drawing.Point(24, 53);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtGeo
            // 
            this.txtGeo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtGeo.BorderRadius = 12;
            this.txtGeo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeo.DefaultText = "";
            this.txtGeo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtGeo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtGeo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtGeo.Location = new System.Drawing.Point(26, 202);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.PlaceholderText = "Geo / Google";
            this.txtGeo.SelectedText = "";
            this.txtGeo.Size = new System.Drawing.Size(278, 36);
            this.txtGeo.TabIndex = 7;
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblGeo.Location = new System.Drawing.Point(24, 183);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(77, 15);
            this.lblGeo.TabIndex = 6;
            this.lblGeo.Text = "Geo / Google";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.txtDireccion.BorderRadius = 12;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.txtDireccion.Location = new System.Drawing.Point(26, 140);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Direccion";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(278, 36);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
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
            this.lblDomicilioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblDomicilioTitulo.Location = new System.Drawing.Point(22, 19);
            this.lblDomicilioTitulo.Name = "lblDomicilioTitulo";
            this.lblDomicilioTitulo.Size = new System.Drawing.Size(79, 21);
            this.lblDomicilioTitulo.TabIndex = 0;
            this.lblDomicilioTitulo.Text = "Domicilio";
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
            this.btnGuardar.Location = new System.Drawing.Point(252, 778);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIconoTitulo
            // 
            this.lblIconoTitulo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 34F);
            this.lblIconoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(171)))), ((int)(((byte)(131)))));
            this.lblIconoTitulo.Location = new System.Drawing.Point(38, 33);
            this.lblIconoTitulo.Name = "lblIconoTitulo";
            this.lblIconoTitulo.Size = new System.Drawing.Size(34, 34);
            this.lblIconoTitulo.TabIndex = 6;
            this.lblIconoTitulo.Text = "";
            this.lblIconoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineaTitulo
            // 
            this.lineaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.lineaTitulo.Location = new System.Drawing.Point(40, 106);
            this.lineaTitulo.Name = "lineaTitulo";
            this.lineaTitulo.Size = new System.Drawing.Size(692, 1);
            this.lineaTitulo.TabIndex = 7;
            // 
            // grpDatosCargados
            // 
            this.grpDatosCargados.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosCargados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.grpDatosCargados.BorderRadius = 14;
            this.grpDatosCargados.BorderThickness = 1;
            this.grpDatosCargados.Controls.Add(this.pnlResumenDomicilio);
            this.grpDatosCargados.Controls.Add(this.pnlResumenDatos);
            this.grpDatosCargados.Controls.Add(this.pnlResumenActualizado);
            this.grpDatosCargados.Controls.Add(this.lblResumenSubtitulo);
            this.grpDatosCargados.Controls.Add(this.lblResumenTitulo);
            this.grpDatosCargados.Controls.Add(this.lblResumenIcono);
            this.grpDatosCargados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.grpDatosCargados.Location = new System.Drawing.Point(40, 118);
            this.grpDatosCargados.Name = "grpDatosCargados";
            this.grpDatosCargados.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.grpDatosCargados.ShadowDecoration.Depth = 8;
            this.grpDatosCargados.ShadowDecoration.Enabled = true;
            this.grpDatosCargados.Size = new System.Drawing.Size(692, 264);
            this.grpDatosCargados.TabIndex = 8;
            // 
            // pnlResumenDomicilio
            // 
            this.pnlResumenDomicilio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlResumenDomicilio.BorderRadius = 8;
            this.pnlResumenDomicilio.BorderThickness = 1;
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomGeoValor);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomGeo);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomProvinciaValor);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomProvincia);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomLocalidadValor);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomLocalidad);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomDireccionValor);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomDireccion);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomTitulo);
            this.pnlResumenDomicilio.Controls.Add(this.lblResumenDomIcono);
            this.pnlResumenDomicilio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.pnlResumenDomicilio.Location = new System.Drawing.Point(346, 78);
            this.pnlResumenDomicilio.Name = "pnlResumenDomicilio";
            this.pnlResumenDomicilio.Size = new System.Drawing.Size(328, 143);
            this.pnlResumenDomicilio.TabIndex = 5;
            // 
            // lblResumenDomGeoValor
            // 
            this.lblResumenDomGeoValor.AutoEllipsis = true;
            this.lblResumenDomGeoValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomGeoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDomGeoValor.Location = new System.Drawing.Point(146, 106);
            this.lblResumenDomGeoValor.Name = "lblResumenDomGeoValor";
            this.lblResumenDomGeoValor.Size = new System.Drawing.Size(290, 16);
            this.lblResumenDomGeoValor.TabIndex = 0;
            this.lblResumenDomGeoValor.Text = "-";
            // 
            // lblResumenDomGeo
            // 
            this.lblResumenDomGeo.AutoSize = true;
            this.lblResumenDomGeo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomGeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenDomGeo.Location = new System.Drawing.Point(159, 91);
            this.lblResumenDomGeo.Name = "lblResumenDomGeo";
            this.lblResumenDomGeo.Size = new System.Drawing.Size(77, 15);
            this.lblResumenDomGeo.TabIndex = 1;
            this.lblResumenDomGeo.Text = "Geo / Google";
            // 
            // pnlResumenEstado
            // 
            this.pnlResumenEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(132)))));
            this.pnlResumenEstado.BorderRadius = 8;
            this.pnlResumenEstado.BorderThickness = 1;
            this.pnlResumenEstado.Controls.Add(this.lblResumenEstadoValor);
            this.pnlResumenEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.pnlResumenEstado.Location = new System.Drawing.Point(18, 112);
            this.pnlResumenEstado.Name = "pnlResumenEstado";
            this.pnlResumenEstado.Size = new System.Drawing.Size(74, 22);
            this.pnlResumenEstado.TabIndex = 2;
            // 
            // lblResumenEstadoValor
            // 
            this.lblResumenEstadoValor.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenEstadoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(102)))), ((int)(((byte)(52)))));
            this.lblResumenEstadoValor.Location = new System.Drawing.Point(1, 0);
            this.lblResumenEstadoValor.Name = "lblResumenEstadoValor";
            this.lblResumenEstadoValor.Size = new System.Drawing.Size(74, 18);
            this.lblResumenEstadoValor.TabIndex = 0;
            this.lblResumenEstadoValor.Text = "Activo";
            this.lblResumenEstadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResumenEstado
            // 
            this.lblResumenEstado.AutoSize = true;
            this.lblResumenEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenEstado.Location = new System.Drawing.Point(15, 90);
            this.lblResumenEstado.Name = "lblResumenEstado";
            this.lblResumenEstado.Size = new System.Drawing.Size(42, 15);
            this.lblResumenEstado.TabIndex = 3;
            this.lblResumenEstado.Text = "Estado";
            // 
            // lblResumenDomProvinciaValor
            // 
            this.lblResumenDomProvinciaValor.AutoEllipsis = true;
            this.lblResumenDomProvinciaValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomProvinciaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDomProvinciaValor.Location = new System.Drawing.Point(20, 106);
            this.lblResumenDomProvinciaValor.Name = "lblResumenDomProvinciaValor";
            this.lblResumenDomProvinciaValor.Size = new System.Drawing.Size(140, 16);
            this.lblResumenDomProvinciaValor.TabIndex = 4;
            this.lblResumenDomProvinciaValor.Text = "-";
            // 
            // lblResumenDomProvincia
            // 
            this.lblResumenDomProvincia.AutoSize = true;
            this.lblResumenDomProvincia.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenDomProvincia.Location = new System.Drawing.Point(20, 90);
            this.lblResumenDomProvincia.Name = "lblResumenDomProvincia";
            this.lblResumenDomProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblResumenDomProvincia.TabIndex = 5;
            this.lblResumenDomProvincia.Text = "Provincia";
            // 
            // lblResumenDomLocalidadValor
            // 
            this.lblResumenDomLocalidadValor.AutoEllipsis = true;
            this.lblResumenDomLocalidadValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomLocalidadValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDomLocalidadValor.Location = new System.Drawing.Point(178, 66);
            this.lblResumenDomLocalidadValor.Name = "lblResumenDomLocalidadValor";
            this.lblResumenDomLocalidadValor.Size = new System.Drawing.Size(130, 16);
            this.lblResumenDomLocalidadValor.TabIndex = 6;
            this.lblResumenDomLocalidadValor.Text = "-";
            // 
            // lblResumenDomLocalidad
            // 
            this.lblResumenDomLocalidad.AutoSize = true;
            this.lblResumenDomLocalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenDomLocalidad.Location = new System.Drawing.Point(178, 50);
            this.lblResumenDomLocalidad.Name = "lblResumenDomLocalidad";
            this.lblResumenDomLocalidad.Size = new System.Drawing.Size(58, 15);
            this.lblResumenDomLocalidad.TabIndex = 7;
            this.lblResumenDomLocalidad.Text = "Localidad";
            // 
            // lblResumenDomDireccionValor
            // 
            this.lblResumenDomDireccionValor.AutoEllipsis = true;
            this.lblResumenDomDireccionValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomDireccionValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDomDireccionValor.Location = new System.Drawing.Point(20, 66);
            this.lblResumenDomDireccionValor.Name = "lblResumenDomDireccionValor";
            this.lblResumenDomDireccionValor.Size = new System.Drawing.Size(140, 16);
            this.lblResumenDomDireccionValor.TabIndex = 8;
            this.lblResumenDomDireccionValor.Text = "-";
            // 
            // lblResumenDomDireccion
            // 
            this.lblResumenDomDireccion.AutoSize = true;
            this.lblResumenDomDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenDomDireccion.Location = new System.Drawing.Point(20, 50);
            this.lblResumenDomDireccion.Name = "lblResumenDomDireccion";
            this.lblResumenDomDireccion.Size = new System.Drawing.Size(58, 15);
            this.lblResumenDomDireccion.TabIndex = 9;
            this.lblResumenDomDireccion.Text = "Direccion";
            // 
            // lblResumenDomTitulo
            // 
            this.lblResumenDomTitulo.AutoSize = true;
            this.lblResumenDomTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumenDomTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDomTitulo.Location = new System.Drawing.Point(44, 16);
            this.lblResumenDomTitulo.Name = "lblResumenDomTitulo";
            this.lblResumenDomTitulo.Size = new System.Drawing.Size(70, 19);
            this.lblResumenDomTitulo.TabIndex = 10;
            this.lblResumenDomTitulo.Text = "Domicilio";
            // 
            // lblResumenDomIcono
            // 
            this.lblResumenDomIcono.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F);
            this.lblResumenDomIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.lblResumenDomIcono.Location = new System.Drawing.Point(18, 17);
            this.lblResumenDomIcono.Name = "lblResumenDomIcono";
            this.lblResumenDomIcono.Size = new System.Drawing.Size(28, 28);
            this.lblResumenDomIcono.TabIndex = 11;
            this.lblResumenDomIcono.Text = "";
            this.lblResumenDomIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResumenDatos
            // 
            this.pnlResumenDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlResumenDatos.BorderRadius = 8;
            this.pnlResumenDatos.BorderThickness = 1;
            this.pnlResumenDatos.Controls.Add(this.lblResumenNombreValor);
            this.pnlResumenDatos.Controls.Add(this.pnlResumenEstado);
            this.pnlResumenDatos.Controls.Add(this.lblResumenNombre);
            this.pnlResumenDatos.Controls.Add(this.lblResumenApellidoValor);
            this.pnlResumenDatos.Controls.Add(this.lblResumenEstado);
            this.pnlResumenDatos.Controls.Add(this.lblResumenApellido);
            this.pnlResumenDatos.Controls.Add(this.lblResumenDniValor);
            this.pnlResumenDatos.Controls.Add(this.lblResumenDni);
            this.pnlResumenDatos.Controls.Add(this.lblResumenDatosTitulo);
            this.pnlResumenDatos.Controls.Add(this.lblResumenDatosIcono);
            this.pnlResumenDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.pnlResumenDatos.Location = new System.Drawing.Point(18, 78);
            this.pnlResumenDatos.Name = "pnlResumenDatos";
            this.pnlResumenDatos.Size = new System.Drawing.Size(328, 143);
            this.pnlResumenDatos.TabIndex = 4;
            // 
            // lblResumenNombreValor
            // 
            this.lblResumenNombreValor.AutoEllipsis = true;
            this.lblResumenNombreValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenNombreValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenNombreValor.Location = new System.Drawing.Point(220, 66);
            this.lblResumenNombreValor.Name = "lblResumenNombreValor";
            this.lblResumenNombreValor.Size = new System.Drawing.Size(90, 16);
            this.lblResumenNombreValor.TabIndex = 8;
            this.lblResumenNombreValor.Text = "-";
            // 
            // lblResumenNombre
            // 
            this.lblResumenNombre.AutoSize = true;
            this.lblResumenNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenNombre.Location = new System.Drawing.Point(220, 50);
            this.lblResumenNombre.Name = "lblResumenNombre";
            this.lblResumenNombre.Size = new System.Drawing.Size(51, 15);
            this.lblResumenNombre.TabIndex = 9;
            this.lblResumenNombre.Text = "Nombre";
            // 
            // lblResumenApellidoValor
            // 
            this.lblResumenApellidoValor.AutoEllipsis = true;
            this.lblResumenApellidoValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenApellidoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenApellidoValor.Location = new System.Drawing.Point(120, 66);
            this.lblResumenApellidoValor.Name = "lblResumenApellidoValor";
            this.lblResumenApellidoValor.Size = new System.Drawing.Size(90, 16);
            this.lblResumenApellidoValor.TabIndex = 10;
            this.lblResumenApellidoValor.Text = "-";
            // 
            // lblResumenApellido
            // 
            this.lblResumenApellido.AutoSize = true;
            this.lblResumenApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenApellido.Location = new System.Drawing.Point(120, 50);
            this.lblResumenApellido.Name = "lblResumenApellido";
            this.lblResumenApellido.Size = new System.Drawing.Size(51, 15);
            this.lblResumenApellido.TabIndex = 11;
            this.lblResumenApellido.Text = "Apellido";
            // 
            // lblResumenDniValor
            // 
            this.lblResumenDniValor.AutoEllipsis = true;
            this.lblResumenDniValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblResumenDniValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDniValor.Location = new System.Drawing.Point(20, 66);
            this.lblResumenDniValor.Name = "lblResumenDniValor";
            this.lblResumenDniValor.Size = new System.Drawing.Size(90, 16);
            this.lblResumenDniValor.TabIndex = 12;
            this.lblResumenDniValor.Text = "-";
            // 
            // lblResumenDni
            // 
            this.lblResumenDni.AutoSize = true;
            this.lblResumenDni.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenDni.Location = new System.Drawing.Point(20, 50);
            this.lblResumenDni.Name = "lblResumenDni";
            this.lblResumenDni.Size = new System.Drawing.Size(29, 15);
            this.lblResumenDni.TabIndex = 13;
            this.lblResumenDni.Text = "DNI";
            // 
            // lblResumenDatosTitulo
            // 
            this.lblResumenDatosTitulo.AutoSize = true;
            this.lblResumenDatosTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumenDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenDatosTitulo.Location = new System.Drawing.Point(44, 16);
            this.lblResumenDatosTitulo.Name = "lblResumenDatosTitulo";
            this.lblResumenDatosTitulo.Size = new System.Drawing.Size(115, 19);
            this.lblResumenDatosTitulo.TabIndex = 1;
            this.lblResumenDatosTitulo.Text = "Datos personales";
            // 
            // lblResumenDatosIcono
            // 
            this.lblResumenDatosIcono.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F);
            this.lblResumenDatosIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.lblResumenDatosIcono.Location = new System.Drawing.Point(18, 17);
            this.lblResumenDatosIcono.Name = "lblResumenDatosIcono";
            this.lblResumenDatosIcono.Size = new System.Drawing.Size(28, 28);
            this.lblResumenDatosIcono.TabIndex = 0;
            this.lblResumenDatosIcono.Text = "";
            this.lblResumenDatosIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResumenActualizado
            // 
            this.pnlResumenActualizado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.pnlResumenActualizado.BorderRadius = 8;
            this.pnlResumenActualizado.BorderThickness = 1;
            this.pnlResumenActualizado.Controls.Add(this.lblResumenActualizado);
            this.pnlResumenActualizado.Controls.Add(this.lblResumenRefreshIcono);
            this.pnlResumenActualizado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.pnlResumenActualizado.Location = new System.Drawing.Point(540, 22);
            this.pnlResumenActualizado.Name = "pnlResumenActualizado";
            this.pnlResumenActualizado.Size = new System.Drawing.Size(128, 30);
            this.pnlResumenActualizado.TabIndex = 3;
            // 
            // lblResumenActualizado
            // 
            this.lblResumenActualizado.AutoEllipsis = true;
            this.lblResumenActualizado.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblResumenActualizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.lblResumenActualizado.Location = new System.Drawing.Point(30, 6);
            this.lblResumenActualizado.Name = "lblResumenActualizado";
            this.lblResumenActualizado.Size = new System.Drawing.Size(92, 18);
            this.lblResumenActualizado.TabIndex = 1;
            this.lblResumenActualizado.Text = "Actualizado hoy";
            // 
            // lblResumenRefreshIcono
            // 
            this.lblResumenRefreshIcono.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13F);
            this.lblResumenRefreshIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.lblResumenRefreshIcono.Location = new System.Drawing.Point(10, 7);
            this.lblResumenRefreshIcono.Name = "lblResumenRefreshIcono";
            this.lblResumenRefreshIcono.Size = new System.Drawing.Size(18, 18);
            this.lblResumenRefreshIcono.TabIndex = 0;
            this.lblResumenRefreshIcono.Text = "";
            this.lblResumenRefreshIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResumenSubtitulo
            // 
            this.lblResumenSubtitulo.AutoSize = true;
            this.lblResumenSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblResumenSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblResumenSubtitulo.Location = new System.Drawing.Point(64, 42);
            this.lblResumenSubtitulo.Name = "lblResumenSubtitulo";
            this.lblResumenSubtitulo.Size = new System.Drawing.Size(206, 15);
            this.lblResumenSubtitulo.TabIndex = 2;
            this.lblResumenSubtitulo.Text = "Informacion cargada desde el sistema";
            // 
            // lblResumenTitulo
            // 
            this.lblResumenTitulo.AutoSize = true;
            this.lblResumenTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblResumenTitulo.Location = new System.Drawing.Point(64, 18);
            this.lblResumenTitulo.Name = "lblResumenTitulo";
            this.lblResumenTitulo.Size = new System.Drawing.Size(139, 19);
            this.lblResumenTitulo.TabIndex = 1;
            this.lblResumenTitulo.Text = "Resumen del usuario";
            // 
            // lblResumenIcono
            // 
            this.lblResumenIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.lblResumenIcono.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F);
            this.lblResumenIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.lblResumenIcono.Location = new System.Drawing.Point(18, 18);
            this.lblResumenIcono.Name = "lblResumenIcono";
            this.lblResumenIcono.Size = new System.Drawing.Size(34, 34);
            this.lblResumenIcono.TabIndex = 0;
            this.lblResumenIcono.Text = "";
            this.lblResumenIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDomicilio);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpDatosCargados);
            this.Controls.Add(this.lineaTitulo);
            this.Controls.Add(this.lblIconoTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Mi ficha";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpDatosCargados.ResumeLayout(false);
            this.grpDatosCargados.PerformLayout();
            this.pnlResumenDomicilio.ResumeLayout(false);
            this.pnlResumenDomicilio.PerformLayout();
            this.pnlResumenEstado.ResumeLayout(false);
            this.pnlResumenDatos.ResumeLayout(false);
            this.pnlResumenDatos.PerformLayout();
            this.pnlResumenActualizado.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblIconoTitulo;
        private System.Windows.Forms.Panel lineaTitulo;
        private Guna.UI2.WinForms.Guna2Panel grpDatosCargados;
        private System.Windows.Forms.Label lblResumenIcono;
        private System.Windows.Forms.Label lblResumenTitulo;
        private System.Windows.Forms.Label lblResumenSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlResumenActualizado;
        private System.Windows.Forms.Label lblResumenRefreshIcono;
        private System.Windows.Forms.Label lblResumenActualizado;
        private Guna.UI2.WinForms.Guna2Panel pnlResumenDatos;
        private System.Windows.Forms.Label lblResumenDatosIcono;
        private System.Windows.Forms.Label lblResumenDatosTitulo;
        private System.Windows.Forms.Label lblResumenDni;
        private System.Windows.Forms.Label lblResumenDniValor;
        private System.Windows.Forms.Label lblResumenApellido;
        private System.Windows.Forms.Label lblResumenApellidoValor;
        private System.Windows.Forms.Label lblResumenNombre;
        private System.Windows.Forms.Label lblResumenNombreValor;
        private Guna.UI2.WinForms.Guna2Panel pnlResumenDomicilio;
        private System.Windows.Forms.Label lblResumenDomIcono;
        private System.Windows.Forms.Label lblResumenDomTitulo;
        private System.Windows.Forms.Label lblResumenDomDireccion;
        private System.Windows.Forms.Label lblResumenDomDireccionValor;
        private System.Windows.Forms.Label lblResumenDomLocalidad;
        private System.Windows.Forms.Label lblResumenDomLocalidadValor;
        private System.Windows.Forms.Label lblResumenDomProvincia;
        private System.Windows.Forms.Label lblResumenDomProvinciaValor;
        private System.Windows.Forms.Label lblResumenEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlResumenEstado;
        private System.Windows.Forms.Label lblResumenEstadoValor;
        private System.Windows.Forms.Label lblResumenDomGeo;
        private System.Windows.Forms.Label lblResumenDomGeoValor;
    }
}
