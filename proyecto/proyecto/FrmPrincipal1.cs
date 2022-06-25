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
            tabPrincipal.SelectedIndex = 5;
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
            tabPrincipal.SelectedIndex = 2;
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
            QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido,QRCodeGenerator.ECCLevel.H);
            QRCode qrCodigo = new QRCode(qrDatos);

            Image qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White,true);
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

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tableLayoutPanel4_Paint_1(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void codigito_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    
}
