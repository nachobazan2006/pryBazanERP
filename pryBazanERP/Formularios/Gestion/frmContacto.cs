using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pryBazanERP.Conexión;

namespace pryBazanERP.Formulario
{
    public partial class frmContacto : Form
    {
        private readonly classConexion conexion = new classConexion();
        private readonly int idPersonal;
        private readonly string nombrePersona;
        private Label lblEnlace;
        private Guna.UI2.WinForms.Guna2TextBox txtEnlace;

        public frmContacto() : this(0, "")
        {
        }

        public frmContacto(int idPersonal, string nombrePersona)
        {
            InitializeComponent();
            AppIcon.Aplicar(this);
            this.idPersonal = idPersonal;
            this.nombrePersona = nombrePersona;
            AplicarEstiloGrid(dgvContactos);
            CrearCampoEnlace();
            InicializarCombos();
            CargarPantalla();
        }

        private void InicializarCombos()
        {
            cmbMedio.Items.Clear();
            cmbMedio.Items.Add("Mail");
            cmbMedio.Items.Add("Telefono");
            cmbMedio.Items.Add("Red social");
            cmbMedio.SelectedIndex = 0;
            cmbMedio.SelectedIndexChanged += cmbMedio_SelectedIndexChanged;

            cmbUso.Items.Clear();
            cmbUso.Items.Add("Principal");
            cmbUso.Items.Add("Auxilio");
            cmbUso.SelectedIndex = 0;

            ActualizarVistaMedio();
        }

        private void CrearCampoEnlace()
        {
            lblEnlace = new Label();
            lblEnlace.AutoSize = true;
            lblEnlace.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEnlace.ForeColor = Color.FromArgb(84, 60, 42);
            lblEnlace.Location = new Point(24, 267);
            lblEnlace.Name = "lblEnlace";
            lblEnlace.Text = "Enlace";

            txtEnlace = new Guna.UI2.WinForms.Guna2TextBox();
            txtEnlace.BorderColor = Color.FromArgb(218, 198, 174);
            txtEnlace.BorderRadius = 12;
            txtEnlace.Cursor = Cursors.IBeam;
            txtEnlace.DefaultText = "";
            txtEnlace.FillColor = Color.FromArgb(255, 250, 243);
            txtEnlace.FocusedState.BorderColor = Color.FromArgb(111, 74, 45);
            txtEnlace.Font = new Font("Segoe UI", 10F);
            txtEnlace.ForeColor = Color.FromArgb(72, 48, 34);
            txtEnlace.Location = new Point(26, 286);
            txtEnlace.Name = "txtEnlace";
            txtEnlace.PlaceholderText = "https://...";
            txtEnlace.SelectedText = "";
            txtEnlace.Size = new Size(278, 36);

            grpCarga.Controls.Add(lblEnlace);
            grpCarga.Controls.Add(txtEnlace);
        }

        private void CargarPantalla()
        {
           

            if (idPersonal == 0)
            {
                MessageBox.Show("El usuario actual no tiene un personal asociado. No se pueden cargar contactos.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpCarga.Enabled = false;
                btnGuardar.Enabled = false;
               
                dgvContactos.DataSource = null;
                return;
            }

            CargarContactos();
        }

        private void CargarContactos()
        {
            try
            {
                List<classConexion.ContactoItem> contactos = conexion.ObtenerContactosPorPersonal(idPersonal);
                dgvContactos.DataSource = contactos;

                if (dgvContactos.Columns["IdContacto"] != null)
                {
                    dgvContactos.Columns["IdContacto"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los contactos: " + ex.Message, "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje;
            bool guardado = conexion.GuardarContacto(
                idPersonal,
                cmbMedio.Text,
                cmbUso.Text,
                txtDato.Text.Trim(),
                txtEnlace.Text.Trim(),
                out mensaje);

            MessageBox.Show(
                mensaje,
                "Contacto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (guardado)
            {
                LimpiarCampos();
                CargarContactos();
            }
        }

        private void btnLimpiarCarga_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbMedio.Text))
            {
                MessageBox.Show("Seleccione el medio de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMedio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUso.Text))
            {
                MessageBox.Show("Seleccione si el contacto es principal o de auxilio.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUso.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("Ingrese el dato de contacto.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDato.Focus();
                return false;
            }

            if (MedioEsRedSocial() && string.IsNullOrWhiteSpace(txtEnlace.Text))
            {
                MessageBox.Show("Ingrese el enlace de la red social.", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnlace.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            cmbMedio.SelectedIndex = 0;
            cmbUso.SelectedIndex = 0;
            txtDato.Clear();
            txtEnlace.Clear();
            ActualizarVistaMedio();
            txtDato.Focus();
        }

        private void cmbMedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarVistaMedio();
        }

        private void ActualizarVistaMedio()
        {
            bool esRedSocial = MedioEsRedSocial();
            lblDato.Text = esRedSocial ? "Red social" : "Dato";
            txtDato.PlaceholderText = esRedSocial ? "Instagram, Tik Tok, usuario..." : "Mail o telefono";
            lblEnlace.Visible = esRedSocial;
            txtEnlace.Visible = esRedSocial;
            grpCarga.Size = esRedSocial ? new Size(330, 352) : new Size(330, 288);
        }

        private bool MedioEsRedSocial()
        {
            return cmbMedio.Text == "Red social";
        }

        private void AplicarEstiloGrid(DataGridView grid)
        {
            if (grid == null)
            {
                return;
            }

            grid.AllowUserToResizeRows = false;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Color.FromArgb(255, 250, 243);
            grid.GridColor = Color.FromArgb(232, 218, 198);
            grid.ColumnHeadersHeight = 34;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(111, 74, 45);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(111, 74, 45);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 243);
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(72, 48, 34);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 198, 174);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(72, 48, 34);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 243, 235);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(72, 48, 34);
            grid.RowTemplate.Height = 28;
        }
    }
}
