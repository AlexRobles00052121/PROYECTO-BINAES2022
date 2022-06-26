using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using System.Data.SqlClient;

namespace proyecto
{
    public partial class FrmPrincipal1 : Form
    {
        public FrmPrincipal1()
        {
            InitializeComponent();
        }

        private void btnSolocitarEvento_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 3;
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 4;
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 2;
        }

        private void btnListarEvento_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 6;
        }

        private void frmPrincipal1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConnectBibliotec_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 5;
        }

        private void btnConnectEvent_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 1;
        }

        private void btnConnectInicio_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 0;
        }

        private void btnConnetAddUser_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 7;
        }

        private void btnPrestarLibros_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 8;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string contenido = txtTelefono.Text;
            QRCodeGenerator qrGenerador = new QRCodeGenerator();
            QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
            QRCode qrCodigo = new QRCode(qrDatos);

            Image qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);
            codigito.Image = qrImagen;
        }

        private void btnAdjuntarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void FrmPrincipal1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bINAESDataSet2.EVENTO' Puede moverla o quitarla según sea necesario.
            this.eVENTOTableAdapter.Fill(this.bINAESDataSet2.EVENTO);
            // TODO: esta línea de código carga datos en la tabla 'bINAESDataSet1.EJEMPLAR' Puede moverla o quitarla según sea necesario.
            this.eJEMPLARTableAdapter.Fill(this.bINAESDataSet1.EJEMPLAR);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);
            String query = "select * from EJEMPLAR where "+ comboBox1.Text + " like '%"+ textBox1.Text + "%' ";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);

            con.Open();

            BINAESDataSet data = new BINAESDataSet();

            ada.Fill(data, "EJEMPLAR");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "EJEMPLAR";
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.conexion);
            String query = "select * from EVENTO where "+ comboBox2.Text + " like '%"+ textBox24.Text + "%' ";
            SqlDataAdapter ada = new SqlDataAdapter(query, connect);

            connect.Open();

            BINAESDataSet datos = new BINAESDataSet();

            ada.Fill(datos, "EVENTO");

            dataGridView2.DataSource = datos;
            dataGridView2.DataMember = "EVENTO";
        }

        private void ConnectInfo_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedIndex = 9;
        }
    }
}