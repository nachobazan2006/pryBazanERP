namespace pryBazanERP.Formulario
{
    partial class frmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.cardUsuarios = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPerfiles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPerfilesTitulo = new System.Windows.Forms.Label();
            this.metricUsuariosSinFicha = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuariosSinFicha = new System.Windows.Forms.Label();
            this.lblUsuariosSinFichaTitulo = new System.Windows.Forms.Label();
            this.metricUsuariosAdmin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuariosAdmin = new System.Windows.Forms.Label();
            this.lblUsuariosAdminTitulo = new System.Windows.Forms.Label();
            this.metricUsuariosInactivos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuariosInactivos = new System.Windows.Forms.Label();
            this.lblUsuariosInactivosTitulo = new System.Windows.Forms.Label();
            this.metricUsuariosActivos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuariosActivos = new System.Windows.Forms.Label();
            this.lblUsuariosActivosTitulo = new System.Windows.Forms.Label();
            this.metricUsuariosTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuariosTotal = new System.Windows.Forms.Label();
            this.lblUsuariosTotalTitulo = new System.Windows.Forms.Label();
            this.lblUsuariosTexto = new System.Windows.Forms.Label();
            this.lblUsuariosTitulo = new System.Windows.Forms.Label();
            this.cardAuditoria = new Guna.UI2.WinForms.Guna2Panel();
            this.chartAuditoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metricAuditoriaTipos = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAuditoriaTipos = new System.Windows.Forms.Label();
            this.lblAuditoriaTiposTitulo = new System.Windows.Forms.Label();
            this.metricAuditoriaTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAuditoriaTotal = new System.Windows.Forms.Label();
            this.lblAuditoriaTotalTitulo = new System.Windows.Forms.Label();
            this.lblAuditoriaTexto = new System.Windows.Forms.Label();
            this.lblAuditoriaTitulo = new System.Windows.Forms.Label();
            this.cardPersonal = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvContactos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvProvincias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblContactosTitulo = new System.Windows.Forms.Label();
            this.lblProvinciasTitulo = new System.Windows.Forms.Label();
            this.metricPersonalSinContacto = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPersonalSinContacto = new System.Windows.Forms.Label();
            this.lblPersonalSinContactoTitulo = new System.Windows.Forms.Label();
            this.metricPersonalPendiente = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPersonalPendiente = new System.Windows.Forms.Label();
            this.lblPersonalPendienteTitulo = new System.Windows.Forms.Label();
            this.metricPersonalActivo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPersonalActivo = new System.Windows.Forms.Label();
            this.lblPersonalActivoTitulo = new System.Windows.Forms.Label();
            this.metricPersonalTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPersonalTotal = new System.Windows.Forms.Label();
            this.lblPersonalTotalTitulo = new System.Windows.Forms.Label();
            this.lblPersonalTexto = new System.Windows.Forms.Label();
            this.lblPersonalTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.cardUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.metricUsuariosSinFicha.SuspendLayout();
            this.metricUsuariosAdmin.SuspendLayout();
            this.metricUsuariosInactivos.SuspendLayout();
            this.metricUsuariosActivos.SuspendLayout();
            this.metricUsuariosTotal.SuspendLayout();
            this.cardAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAuditoria)).BeginInit();
            this.metricAuditoriaTipos.SuspendLayout();
            this.metricAuditoriaTotal.SuspendLayout();
            this.cardPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).BeginInit();
            this.metricPersonalSinContacto.SuspendLayout();
            this.metricPersonalPendiente.SuspendLayout();
            this.metricPersonalActivo.SuspendLayout();
            this.metricPersonalTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(34, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(38, 72);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(590, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Lectura administrativa y detallada de usuarios, fichas, contactos y actividad";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BorderRadius = 12;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.btnActualizar.Location = new System.Drawing.Point(736, 36);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 38);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.cardUsuarios);
            this.pnlContenido.Location = new System.Drawing.Point(34, 112);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(832, 754);
            this.pnlContenido.TabIndex = 3;
            // 
            // cardUsuarios
            // 
            this.cardUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.cardUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cardUsuarios.BorderRadius = 14;
            this.cardUsuarios.BorderThickness = 1;
            this.cardUsuarios.Controls.Add(this.dgvPerfiles);
            this.cardUsuarios.Controls.Add(this.lblPerfilesTitulo);
            this.cardUsuarios.Controls.Add(this.metricUsuariosSinFicha);
            this.cardUsuarios.Controls.Add(this.metricUsuariosAdmin);
            this.cardUsuarios.Controls.Add(this.metricUsuariosInactivos);
            this.cardUsuarios.Controls.Add(this.metricUsuariosActivos);
            this.cardUsuarios.Controls.Add(this.metricUsuariosTotal);
            this.cardUsuarios.Controls.Add(this.lblUsuariosTexto);
            this.cardUsuarios.Controls.Add(this.lblUsuariosTitulo);
            this.cardUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.cardUsuarios.Location = new System.Drawing.Point(0, 0);
            this.cardUsuarios.Name = "cardUsuarios";
            this.cardUsuarios.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.cardUsuarios.ShadowDecoration.Depth = 8;
            this.cardUsuarios.ShadowDecoration.Enabled = true;
            this.cardUsuarios.Size = new System.Drawing.Size(832, 326);
            this.cardUsuarios.TabIndex = 0;
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.EnableHeadersVisualStyles = false;
            this.dgvPerfiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.dgvPerfiles.Location = new System.Drawing.Point(265, 164);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.ReadOnly = true;
            this.dgvPerfiles.RowHeadersVisible = false;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(301, 159);
            this.dgvPerfiles.TabIndex = 10;
            // 
            // lblPerfilesTitulo
            // 
            this.lblPerfilesTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPerfilesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPerfilesTitulo.Location = new System.Drawing.Point(262, 143);
            this.lblPerfilesTitulo.Name = "lblPerfilesTitulo";
            this.lblPerfilesTitulo.Size = new System.Drawing.Size(150, 18);
            this.lblPerfilesTitulo.TabIndex = 8;
            this.lblPerfilesTitulo.Text = "Perfiles";
            // 
            // metricUsuariosSinFicha
            // 
            this.metricUsuariosSinFicha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricUsuariosSinFicha.BorderRadius = 10;
            this.metricUsuariosSinFicha.BorderThickness = 1;
            this.metricUsuariosSinFicha.Controls.Add(this.lblUsuariosSinFicha);
            this.metricUsuariosSinFicha.Controls.Add(this.lblUsuariosSinFichaTitulo);
            this.metricUsuariosSinFicha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricUsuariosSinFicha.Location = new System.Drawing.Point(648, 76);
            this.metricUsuariosSinFicha.Name = "metricUsuariosSinFicha";
            this.metricUsuariosSinFicha.Size = new System.Drawing.Size(132, 50);
            this.metricUsuariosSinFicha.TabIndex = 6;
            // 
            // lblUsuariosSinFicha
            // 
            this.lblUsuariosSinFicha.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosSinFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosSinFicha.Location = new System.Drawing.Point(12, 7);
            this.lblUsuariosSinFicha.Name = "lblUsuariosSinFicha";
            this.lblUsuariosSinFicha.Size = new System.Drawing.Size(108, 22);
            this.lblUsuariosSinFicha.TabIndex = 0;
            this.lblUsuariosSinFicha.Text = "0";
            // 
            // lblUsuariosSinFichaTitulo
            // 
            this.lblUsuariosSinFichaTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosSinFichaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosSinFichaTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblUsuariosSinFichaTitulo.Name = "lblUsuariosSinFichaTitulo";
            this.lblUsuariosSinFichaTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblUsuariosSinFichaTitulo.TabIndex = 1;
            this.lblUsuariosSinFichaTitulo.Text = "Sin ficha";
            // 
            // metricUsuariosAdmin
            // 
            this.metricUsuariosAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricUsuariosAdmin.BorderRadius = 10;
            this.metricUsuariosAdmin.BorderThickness = 1;
            this.metricUsuariosAdmin.Controls.Add(this.lblUsuariosAdmin);
            this.metricUsuariosAdmin.Controls.Add(this.lblUsuariosAdminTitulo);
            this.metricUsuariosAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricUsuariosAdmin.Location = new System.Drawing.Point(492, 76);
            this.metricUsuariosAdmin.Name = "metricUsuariosAdmin";
            this.metricUsuariosAdmin.Size = new System.Drawing.Size(132, 50);
            this.metricUsuariosAdmin.TabIndex = 5;
            // 
            // lblUsuariosAdmin
            // 
            this.lblUsuariosAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosAdmin.Location = new System.Drawing.Point(12, 7);
            this.lblUsuariosAdmin.Name = "lblUsuariosAdmin";
            this.lblUsuariosAdmin.Size = new System.Drawing.Size(108, 22);
            this.lblUsuariosAdmin.TabIndex = 0;
            this.lblUsuariosAdmin.Text = "0";
            // 
            // lblUsuariosAdminTitulo
            // 
            this.lblUsuariosAdminTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosAdminTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosAdminTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblUsuariosAdminTitulo.Name = "lblUsuariosAdminTitulo";
            this.lblUsuariosAdminTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblUsuariosAdminTitulo.TabIndex = 1;
            this.lblUsuariosAdminTitulo.Text = "Admins";
            // 
            // metricUsuariosInactivos
            // 
            this.metricUsuariosInactivos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricUsuariosInactivos.BorderRadius = 10;
            this.metricUsuariosInactivos.BorderThickness = 1;
            this.metricUsuariosInactivos.Controls.Add(this.lblUsuariosInactivos);
            this.metricUsuariosInactivos.Controls.Add(this.lblUsuariosInactivosTitulo);
            this.metricUsuariosInactivos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricUsuariosInactivos.Location = new System.Drawing.Point(336, 76);
            this.metricUsuariosInactivos.Name = "metricUsuariosInactivos";
            this.metricUsuariosInactivos.Size = new System.Drawing.Size(132, 50);
            this.metricUsuariosInactivos.TabIndex = 4;
            // 
            // lblUsuariosInactivos
            // 
            this.lblUsuariosInactivos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosInactivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosInactivos.Location = new System.Drawing.Point(12, 7);
            this.lblUsuariosInactivos.Name = "lblUsuariosInactivos";
            this.lblUsuariosInactivos.Size = new System.Drawing.Size(108, 22);
            this.lblUsuariosInactivos.TabIndex = 0;
            this.lblUsuariosInactivos.Text = "0";
            // 
            // lblUsuariosInactivosTitulo
            // 
            this.lblUsuariosInactivosTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosInactivosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosInactivosTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblUsuariosInactivosTitulo.Name = "lblUsuariosInactivosTitulo";
            this.lblUsuariosInactivosTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblUsuariosInactivosTitulo.TabIndex = 1;
            this.lblUsuariosInactivosTitulo.Text = "Inactivos";
            // 
            // metricUsuariosActivos
            // 
            this.metricUsuariosActivos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricUsuariosActivos.BorderRadius = 10;
            this.metricUsuariosActivos.BorderThickness = 1;
            this.metricUsuariosActivos.Controls.Add(this.lblUsuariosActivos);
            this.metricUsuariosActivos.Controls.Add(this.lblUsuariosActivosTitulo);
            this.metricUsuariosActivos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricUsuariosActivos.Location = new System.Drawing.Point(180, 76);
            this.metricUsuariosActivos.Name = "metricUsuariosActivos";
            this.metricUsuariosActivos.Size = new System.Drawing.Size(132, 50);
            this.metricUsuariosActivos.TabIndex = 3;
            // 
            // lblUsuariosActivos
            // 
            this.lblUsuariosActivos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosActivos.Location = new System.Drawing.Point(12, 7);
            this.lblUsuariosActivos.Name = "lblUsuariosActivos";
            this.lblUsuariosActivos.Size = new System.Drawing.Size(108, 22);
            this.lblUsuariosActivos.TabIndex = 0;
            this.lblUsuariosActivos.Text = "0";
            // 
            // lblUsuariosActivosTitulo
            // 
            this.lblUsuariosActivosTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosActivosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosActivosTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblUsuariosActivosTitulo.Name = "lblUsuariosActivosTitulo";
            this.lblUsuariosActivosTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblUsuariosActivosTitulo.TabIndex = 1;
            this.lblUsuariosActivosTitulo.Text = "Activos";
            // 
            // metricUsuariosTotal
            // 
            this.metricUsuariosTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricUsuariosTotal.BorderRadius = 10;
            this.metricUsuariosTotal.BorderThickness = 1;
            this.metricUsuariosTotal.Controls.Add(this.lblUsuariosTotal);
            this.metricUsuariosTotal.Controls.Add(this.lblUsuariosTotalTitulo);
            this.metricUsuariosTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricUsuariosTotal.Location = new System.Drawing.Point(24, 76);
            this.metricUsuariosTotal.Name = "metricUsuariosTotal";
            this.metricUsuariosTotal.Size = new System.Drawing.Size(132, 50);
            this.metricUsuariosTotal.TabIndex = 2;
            // 
            // lblUsuariosTotal
            // 
            this.lblUsuariosTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosTotal.Location = new System.Drawing.Point(12, 7);
            this.lblUsuariosTotal.Name = "lblUsuariosTotal";
            this.lblUsuariosTotal.Size = new System.Drawing.Size(108, 22);
            this.lblUsuariosTotal.TabIndex = 0;
            this.lblUsuariosTotal.Text = "0";
            // 
            // lblUsuariosTotalTitulo
            // 
            this.lblUsuariosTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosTotalTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblUsuariosTotalTitulo.Name = "lblUsuariosTotalTitulo";
            this.lblUsuariosTotalTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblUsuariosTotalTitulo.TabIndex = 1;
            this.lblUsuariosTotalTitulo.Text = "Usuarios";
            // 
            // lblUsuariosTexto
            // 
            this.lblUsuariosTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuariosTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblUsuariosTexto.Location = new System.Drawing.Point(26, 45);
            this.lblUsuariosTexto.Name = "lblUsuariosTexto";
            this.lblUsuariosTexto.Size = new System.Drawing.Size(610, 20);
            this.lblUsuariosTexto.TabIndex = 1;
            this.lblUsuariosTexto.Text = "Estado de usuarios, perfiles y cobertura de ficha personal.";
            // 
            // lblUsuariosTitulo
            // 
            this.lblUsuariosTitulo.AutoSize = true;
            this.lblUsuariosTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblUsuariosTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblUsuariosTitulo.Name = "lblUsuariosTitulo";
            this.lblUsuariosTitulo.Size = new System.Drawing.Size(178, 25);
            this.lblUsuariosTitulo.TabIndex = 0;
            this.lblUsuariosTitulo.Text = "Seguridad y accesos";
            // 
            // cardAuditoria
            // 
            this.cardAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.cardAuditoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cardAuditoria.BorderRadius = 14;
            this.cardAuditoria.BorderThickness = 1;
            this.cardAuditoria.Controls.Add(this.chartAuditoria);
            this.cardAuditoria.Controls.Add(this.metricAuditoriaTipos);
            this.cardAuditoria.Controls.Add(this.metricAuditoriaTotal);
            this.cardAuditoria.Controls.Add(this.lblAuditoriaTexto);
            this.cardAuditoria.Controls.Add(this.lblAuditoriaTitulo);
            this.cardAuditoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.cardAuditoria.Location = new System.Drawing.Point(31, 695);
            this.cardAuditoria.Name = "cardAuditoria";
            this.cardAuditoria.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.cardAuditoria.ShadowDecoration.Depth = 8;
            this.cardAuditoria.ShadowDecoration.Enabled = true;
            this.cardAuditoria.Size = new System.Drawing.Size(832, 228);
            this.cardAuditoria.TabIndex = 2;
            // 
            // chartAuditoria
            // 
            this.chartAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.chartAuditoria.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.chartAuditoria.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(205)))), ((int)(((byte)(190)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            chartArea3.Name = "AreaPrincipal";
            this.chartAuditoria.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartAuditoria.Legends.Add(legend3);
            this.chartAuditoria.Location = new System.Drawing.Point(336, 76);
            this.chartAuditoria.Name = "chartAuditoria";
            series3.ChartArea = "AreaPrincipal";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            series3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Acciones";
            this.chartAuditoria.Series.Add(series3);
            this.chartAuditoria.Size = new System.Drawing.Size(472, 126);
            this.chartAuditoria.TabIndex = 4;
            // 
            // metricAuditoriaTipos
            // 
            this.metricAuditoriaTipos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricAuditoriaTipos.BorderRadius = 10;
            this.metricAuditoriaTipos.BorderThickness = 1;
            this.metricAuditoriaTipos.Controls.Add(this.lblAuditoriaTipos);
            this.metricAuditoriaTipos.Controls.Add(this.lblAuditoriaTiposTitulo);
            this.metricAuditoriaTipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricAuditoriaTipos.Location = new System.Drawing.Point(180, 76);
            this.metricAuditoriaTipos.Name = "metricAuditoriaTipos";
            this.metricAuditoriaTipos.Size = new System.Drawing.Size(132, 50);
            this.metricAuditoriaTipos.TabIndex = 3;
            // 
            // lblAuditoriaTipos
            // 
            this.lblAuditoriaTipos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblAuditoriaTipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblAuditoriaTipos.Location = new System.Drawing.Point(12, 7);
            this.lblAuditoriaTipos.Name = "lblAuditoriaTipos";
            this.lblAuditoriaTipos.Size = new System.Drawing.Size(108, 22);
            this.lblAuditoriaTipos.TabIndex = 0;
            this.lblAuditoriaTipos.Text = "0";
            // 
            // lblAuditoriaTiposTitulo
            // 
            this.lblAuditoriaTiposTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAuditoriaTiposTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblAuditoriaTiposTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblAuditoriaTiposTitulo.Name = "lblAuditoriaTiposTitulo";
            this.lblAuditoriaTiposTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblAuditoriaTiposTitulo.TabIndex = 1;
            this.lblAuditoriaTiposTitulo.Text = "Tipos";
            // 
            // metricAuditoriaTotal
            // 
            this.metricAuditoriaTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricAuditoriaTotal.BorderRadius = 10;
            this.metricAuditoriaTotal.BorderThickness = 1;
            this.metricAuditoriaTotal.Controls.Add(this.lblAuditoriaTotal);
            this.metricAuditoriaTotal.Controls.Add(this.lblAuditoriaTotalTitulo);
            this.metricAuditoriaTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricAuditoriaTotal.Location = new System.Drawing.Point(24, 76);
            this.metricAuditoriaTotal.Name = "metricAuditoriaTotal";
            this.metricAuditoriaTotal.Size = new System.Drawing.Size(132, 50);
            this.metricAuditoriaTotal.TabIndex = 2;
            // 
            // lblAuditoriaTotal
            // 
            this.lblAuditoriaTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblAuditoriaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblAuditoriaTotal.Location = new System.Drawing.Point(12, 7);
            this.lblAuditoriaTotal.Name = "lblAuditoriaTotal";
            this.lblAuditoriaTotal.Size = new System.Drawing.Size(108, 22);
            this.lblAuditoriaTotal.TabIndex = 0;
            this.lblAuditoriaTotal.Text = "0";
            // 
            // lblAuditoriaTotalTitulo
            // 
            this.lblAuditoriaTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAuditoriaTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblAuditoriaTotalTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblAuditoriaTotalTitulo.Name = "lblAuditoriaTotalTitulo";
            this.lblAuditoriaTotalTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblAuditoriaTotalTitulo.TabIndex = 1;
            this.lblAuditoriaTotalTitulo.Text = "Eventos";
            // 
            // lblAuditoriaTexto
            // 
            this.lblAuditoriaTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAuditoriaTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblAuditoriaTexto.Location = new System.Drawing.Point(20, 53);
            this.lblAuditoriaTexto.Name = "lblAuditoriaTexto";
            this.lblAuditoriaTexto.Size = new System.Drawing.Size(610, 20);
            this.lblAuditoriaTexto.TabIndex = 1;
            this.lblAuditoriaTexto.Text = "Ranking de eventos registrados en la auditoria del sistema.";
            // 
            // lblAuditoriaTitulo
            // 
            this.lblAuditoriaTitulo.AutoSize = true;
            this.lblAuditoriaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblAuditoriaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblAuditoriaTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblAuditoriaTitulo.Name = "lblAuditoriaTitulo";
            this.lblAuditoriaTitulo.Size = new System.Drawing.Size(206, 25);
            this.lblAuditoriaTitulo.TabIndex = 0;
            this.lblAuditoriaTitulo.Text = "Acciones mas repetidas";
            // 
            // cardPersonal
            // 
            this.cardPersonal.BackColor = System.Drawing.Color.Transparent;
            this.cardPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.cardPersonal.BorderRadius = 14;
            this.cardPersonal.BorderThickness = 1;
            this.cardPersonal.Controls.Add(this.dgvContactos);
            this.cardPersonal.Controls.Add(this.dgvProvincias);
            this.cardPersonal.Controls.Add(this.lblContactosTitulo);
            this.cardPersonal.Controls.Add(this.lblProvinciasTitulo);
            this.cardPersonal.Controls.Add(this.metricPersonalSinContacto);
            this.cardPersonal.Controls.Add(this.metricPersonalPendiente);
            this.cardPersonal.Controls.Add(this.metricPersonalActivo);
            this.cardPersonal.Controls.Add(this.metricPersonalTotal);
            this.cardPersonal.Controls.Add(this.lblPersonalTexto);
            this.cardPersonal.Controls.Add(this.lblPersonalTitulo);
            this.cardPersonal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.cardPersonal.Location = new System.Drawing.Point(31, 444);
            this.cardPersonal.Name = "cardPersonal";
            this.cardPersonal.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.cardPersonal.ShadowDecoration.Depth = 8;
            this.cardPersonal.ShadowDecoration.Enabled = true;
            this.cardPersonal.Size = new System.Drawing.Size(832, 245);
            this.cardPersonal.TabIndex = 1;
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.EnableHeadersVisualStyles = false;
            this.dgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.dgvContactos.Location = new System.Drawing.Point(430, 164);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(378, 58);
            this.dgvContactos.TabIndex = 9;
            // 
            // dgvProvincias
            // 
            this.dgvProvincias.AllowUserToAddRows = false;
            this.dgvProvincias.AllowUserToDeleteRows = false;
            this.dgvProvincias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvincias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.dgvProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincias.EnableHeadersVisualStyles = false;
            this.dgvProvincias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.dgvProvincias.Location = new System.Drawing.Point(24, 164);
            this.dgvProvincias.Name = "dgvProvincias";
            this.dgvProvincias.ReadOnly = true;
            this.dgvProvincias.RowHeadersVisible = false;
            this.dgvProvincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvincias.Size = new System.Drawing.Size(380, 58);
            this.dgvProvincias.TabIndex = 8;
            // 
            // lblContactosTitulo
            // 
            this.lblContactosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblContactosTitulo.Location = new System.Drawing.Point(430, 142);
            this.lblContactosTitulo.Name = "lblContactosTitulo";
            this.lblContactosTitulo.Size = new System.Drawing.Size(200, 18);
            this.lblContactosTitulo.TabIndex = 7;
            this.lblContactosTitulo.Text = "Medios de contacto";
            // 
            // lblProvinciasTitulo
            // 
            this.lblProvinciasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProvinciasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblProvinciasTitulo.Location = new System.Drawing.Point(26, 142);
            this.lblProvinciasTitulo.Name = "lblProvinciasTitulo";
            this.lblProvinciasTitulo.Size = new System.Drawing.Size(180, 18);
            this.lblProvinciasTitulo.TabIndex = 6;
            this.lblProvinciasTitulo.Text = "Provincias";
            // 
            // metricPersonalSinContacto
            // 
            this.metricPersonalSinContacto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricPersonalSinContacto.BorderRadius = 10;
            this.metricPersonalSinContacto.BorderThickness = 1;
            this.metricPersonalSinContacto.Controls.Add(this.lblPersonalSinContacto);
            this.metricPersonalSinContacto.Controls.Add(this.lblPersonalSinContactoTitulo);
            this.metricPersonalSinContacto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricPersonalSinContacto.Location = new System.Drawing.Point(492, 76);
            this.metricPersonalSinContacto.Name = "metricPersonalSinContacto";
            this.metricPersonalSinContacto.Size = new System.Drawing.Size(132, 50);
            this.metricPersonalSinContacto.TabIndex = 5;
            // 
            // lblPersonalSinContacto
            // 
            this.lblPersonalSinContacto.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPersonalSinContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPersonalSinContacto.Location = new System.Drawing.Point(12, 7);
            this.lblPersonalSinContacto.Name = "lblPersonalSinContacto";
            this.lblPersonalSinContacto.Size = new System.Drawing.Size(108, 22);
            this.lblPersonalSinContacto.TabIndex = 0;
            this.lblPersonalSinContacto.Text = "0";
            // 
            // lblPersonalSinContactoTitulo
            // 
            this.lblPersonalSinContactoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPersonalSinContactoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPersonalSinContactoTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblPersonalSinContactoTitulo.Name = "lblPersonalSinContactoTitulo";
            this.lblPersonalSinContactoTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblPersonalSinContactoTitulo.TabIndex = 1;
            this.lblPersonalSinContactoTitulo.Text = "Sin contacto";
            // 
            // metricPersonalPendiente
            // 
            this.metricPersonalPendiente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricPersonalPendiente.BorderRadius = 10;
            this.metricPersonalPendiente.BorderThickness = 1;
            this.metricPersonalPendiente.Controls.Add(this.lblPersonalPendiente);
            this.metricPersonalPendiente.Controls.Add(this.lblPersonalPendienteTitulo);
            this.metricPersonalPendiente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricPersonalPendiente.Location = new System.Drawing.Point(336, 76);
            this.metricPersonalPendiente.Name = "metricPersonalPendiente";
            this.metricPersonalPendiente.Size = new System.Drawing.Size(132, 50);
            this.metricPersonalPendiente.TabIndex = 4;
            // 
            // lblPersonalPendiente
            // 
            this.lblPersonalPendiente.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPersonalPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPersonalPendiente.Location = new System.Drawing.Point(12, 7);
            this.lblPersonalPendiente.Name = "lblPersonalPendiente";
            this.lblPersonalPendiente.Size = new System.Drawing.Size(108, 22);
            this.lblPersonalPendiente.TabIndex = 0;
            this.lblPersonalPendiente.Text = "0";
            // 
            // lblPersonalPendienteTitulo
            // 
            this.lblPersonalPendienteTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPersonalPendienteTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPersonalPendienteTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblPersonalPendienteTitulo.Name = "lblPersonalPendienteTitulo";
            this.lblPersonalPendienteTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblPersonalPendienteTitulo.TabIndex = 1;
            this.lblPersonalPendienteTitulo.Text = "Ficha pendiente";
            // 
            // metricPersonalActivo
            // 
            this.metricPersonalActivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricPersonalActivo.BorderRadius = 10;
            this.metricPersonalActivo.BorderThickness = 1;
            this.metricPersonalActivo.Controls.Add(this.lblPersonalActivo);
            this.metricPersonalActivo.Controls.Add(this.lblPersonalActivoTitulo);
            this.metricPersonalActivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricPersonalActivo.Location = new System.Drawing.Point(180, 76);
            this.metricPersonalActivo.Name = "metricPersonalActivo";
            this.metricPersonalActivo.Size = new System.Drawing.Size(132, 50);
            this.metricPersonalActivo.TabIndex = 3;
            // 
            // lblPersonalActivo
            // 
            this.lblPersonalActivo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPersonalActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPersonalActivo.Location = new System.Drawing.Point(12, 7);
            this.lblPersonalActivo.Name = "lblPersonalActivo";
            this.lblPersonalActivo.Size = new System.Drawing.Size(108, 22);
            this.lblPersonalActivo.TabIndex = 0;
            this.lblPersonalActivo.Text = "0";
            // 
            // lblPersonalActivoTitulo
            // 
            this.lblPersonalActivoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPersonalActivoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPersonalActivoTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblPersonalActivoTitulo.Name = "lblPersonalActivoTitulo";
            this.lblPersonalActivoTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblPersonalActivoTitulo.TabIndex = 1;
            this.lblPersonalActivoTitulo.Text = "Activos";
            // 
            // metricPersonalTotal
            // 
            this.metricPersonalTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(198)))), ((int)(((byte)(174)))));
            this.metricPersonalTotal.BorderRadius = 10;
            this.metricPersonalTotal.BorderThickness = 1;
            this.metricPersonalTotal.Controls.Add(this.lblPersonalTotal);
            this.metricPersonalTotal.Controls.Add(this.lblPersonalTotalTitulo);
            this.metricPersonalTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.metricPersonalTotal.Location = new System.Drawing.Point(24, 76);
            this.metricPersonalTotal.Name = "metricPersonalTotal";
            this.metricPersonalTotal.Size = new System.Drawing.Size(132, 50);
            this.metricPersonalTotal.TabIndex = 2;
            // 
            // lblPersonalTotal
            // 
            this.lblPersonalTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPersonalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPersonalTotal.Location = new System.Drawing.Point(12, 7);
            this.lblPersonalTotal.Name = "lblPersonalTotal";
            this.lblPersonalTotal.Size = new System.Drawing.Size(108, 22);
            this.lblPersonalTotal.TabIndex = 0;
            this.lblPersonalTotal.Text = "0";
            // 
            // lblPersonalTotalTitulo
            // 
            this.lblPersonalTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPersonalTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPersonalTotalTitulo.Location = new System.Drawing.Point(12, 30);
            this.lblPersonalTotalTitulo.Name = "lblPersonalTotalTitulo";
            this.lblPersonalTotalTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblPersonalTotalTitulo.TabIndex = 1;
            this.lblPersonalTotalTitulo.Text = "Personal";
            // 
            // lblPersonalTexto
            // 
            this.lblPersonalTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPersonalTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.lblPersonalTexto.Location = new System.Drawing.Point(26, 45);
            this.lblPersonalTexto.Name = "lblPersonalTexto";
            this.lblPersonalTexto.Size = new System.Drawing.Size(650, 20);
            this.lblPersonalTexto.TabIndex = 1;
            this.lblPersonalTexto.Text = "Cobertura de fichas, ubicacion y canales de contacto cargados.";
            // 
            // lblPersonalTitulo
            // 
            this.lblPersonalTitulo.AutoSize = true;
            this.lblPersonalTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblPersonalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.lblPersonalTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblPersonalTitulo.Name = "lblPersonalTitulo";
            this.lblPersonalTitulo.Size = new System.Drawing.Size(182, 25);
            this.lblPersonalTitulo.TabIndex = 0;
            this.lblPersonalTitulo.Text = "Personal y contactos";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(900, 961);
            this.Controls.Add(this.cardPersonal);
            this.Controls.Add(this.cardAuditoria);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bazan ERP - Reportes";
            this.pnlContenido.ResumeLayout(false);
            this.cardUsuarios.ResumeLayout(false);
            this.cardUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.metricUsuariosSinFicha.ResumeLayout(false);
            this.metricUsuariosAdmin.ResumeLayout(false);
            this.metricUsuariosInactivos.ResumeLayout(false);
            this.metricUsuariosActivos.ResumeLayout(false);
            this.metricUsuariosTotal.ResumeLayout(false);
            this.cardAuditoria.ResumeLayout(false);
            this.cardAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAuditoria)).EndInit();
            this.metricAuditoriaTipos.ResumeLayout(false);
            this.metricAuditoriaTotal.ResumeLayout(false);
            this.cardPersonal.ResumeLayout(false);
            this.cardPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).EndInit();
            this.metricPersonalSinContacto.ResumeLayout(false);
            this.metricPersonalPendiente.ResumeLayout(false);
            this.metricPersonalActivo.ResumeLayout(false);
            this.metricPersonalTotal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private System.Windows.Forms.Panel pnlContenido;
        private Guna.UI2.WinForms.Guna2Panel cardUsuarios;
        private Guna.UI2.WinForms.Guna2Panel cardPersonal;
        private Guna.UI2.WinForms.Guna2Panel cardAuditoria;
        private System.Windows.Forms.Label lblUsuariosTotal;
        private System.Windows.Forms.Label lblUsuariosActivos;
        private System.Windows.Forms.Label lblUsuariosInactivos;
        private System.Windows.Forms.Label lblUsuariosAdmin;
        private System.Windows.Forms.Label lblUsuariosSinFicha;
        private System.Windows.Forms.Label lblPersonalTotal;
        private System.Windows.Forms.Label lblPersonalActivo;
        private System.Windows.Forms.Label lblPersonalPendiente;
        private System.Windows.Forms.Label lblPersonalSinContacto;
        private System.Windows.Forms.Label lblAuditoriaTotal;
        private System.Windows.Forms.Label lblAuditoriaTipos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPerfiles;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProvincias;
        private Guna.UI2.WinForms.Guna2DataGridView dgvContactos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAuditoria;
        private System.Windows.Forms.Label lblAuditoriaTiposTitulo;
        private System.Windows.Forms.Label lblAuditoriaTotalTitulo;
        private System.Windows.Forms.Label lblAuditoriaTexto;
        private System.Windows.Forms.Label lblAuditoriaTitulo;
        private System.Windows.Forms.Label lblContactosTitulo;
        private System.Windows.Forms.Label lblProvinciasTitulo;
        private System.Windows.Forms.Label lblPersonalSinContactoTitulo;
        private System.Windows.Forms.Label lblPersonalPendienteTitulo;
        private System.Windows.Forms.Label lblPersonalActivoTitulo;
        private System.Windows.Forms.Label lblPersonalTotalTitulo;
        private System.Windows.Forms.Label lblPersonalTexto;
        private System.Windows.Forms.Label lblPersonalTitulo;
        private System.Windows.Forms.Label lblPerfilesTitulo;
        private System.Windows.Forms.Label lblUsuariosSinFichaTitulo;
        private System.Windows.Forms.Label lblUsuariosAdminTitulo;
        private System.Windows.Forms.Label lblUsuariosInactivosTitulo;
        private System.Windows.Forms.Label lblUsuariosActivosTitulo;
        private System.Windows.Forms.Label lblUsuariosTotalTitulo;
        private System.Windows.Forms.Label lblUsuariosTexto;
        private System.Windows.Forms.Label lblUsuariosTitulo;
        private Guna.UI2.WinForms.Guna2Panel metricUsuariosTotal;
        private Guna.UI2.WinForms.Guna2Panel metricUsuariosActivos;
        private Guna.UI2.WinForms.Guna2Panel metricUsuariosInactivos;
        private Guna.UI2.WinForms.Guna2Panel metricUsuariosAdmin;
        private Guna.UI2.WinForms.Guna2Panel metricUsuariosSinFicha;
        private Guna.UI2.WinForms.Guna2Panel metricPersonalTotal;
        private Guna.UI2.WinForms.Guna2Panel metricPersonalActivo;
        private Guna.UI2.WinForms.Guna2Panel metricPersonalPendiente;
        private Guna.UI2.WinForms.Guna2Panel metricPersonalSinContacto;
        private Guna.UI2.WinForms.Guna2Panel metricAuditoriaTotal;
        private Guna.UI2.WinForms.Guna2Panel metricAuditoriaTipos;
    }
}
