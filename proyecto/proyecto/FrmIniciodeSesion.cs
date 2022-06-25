using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto
{
    public partial class FrmIniciodeSesion : Form
    {
        public FrmIniciodeSesion()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=BINAES;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select Nombre, Contraseña from ADMINISTRADOR where Nombre ='" + Correo.Text + "' and Contraseña ='" + Contraseña.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Exitoso", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPrincipal1 ventana = new FrmPrincipal1();
                ventana.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de Credendiales", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

