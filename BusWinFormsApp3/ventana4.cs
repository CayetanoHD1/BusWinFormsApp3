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

namespace BusWinFormsApp3
{
    public partial class ventana4 : Form
    {
        public ventana4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("SERVER= (localdb)\\MSSQLLOCALDB;DATABASE=LoginMD;integrated Security = true");
        public void save()
        {
            try
            {   
                con.Open();
                var qry = "insert into Rutas ([Ruta])" +
                   "values ('" + txtRuta.Text + "')";
                SqlCommand cdm = new SqlCommand(qry, con);
                cdm.ExecuteNonQuery();
                
                
                SqlDataReader dr = cdm.ExecuteReader();
                
                    MessageBox.Show($"Ruta {txtRuta.Text} agregada exitosamente");

                
               


                txtRuta.Text = "";

                    con.Close();

            }
            
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }

        }
        private void cerrar_v2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void minimizar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_v4_Click(object sender, EventArgs e)
        {
             
        }

        private void restaurar_v4_Click(object sender, EventArgs e)
        { 
        }

        private void ventana4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
