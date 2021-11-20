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
    public partial class ventana1 : Form
    {
        public ventana1()
        {
            InitializeComponent();

        }


        /* SqlConnection sql = new SqlConnection(@"Data Source =DESKTOP-EOJG6OO\\SQLEXPRESSS");*/
        SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
        public void logear()
        {
            try
            {
               
               
               
               ventana2 win2 = new ventana2();
                
                con.Open();
                var qry = "SELECT Correo, Rol, Clave,Nombre from Usuarios where Correo='" + caja_correo.Text + "' and Rol ='" + cmb_Rol.Text + "' and Clave='" + caja_pass.Text+"'";
                using (SqlCommand cdm = new SqlCommand(qry, con))
                {
                    
                    SqlDataReader dr = cdm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Bienvenido");
                        
                        
                        win2.Show();
                     
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            logear();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* con.Open();
            MessageBox.Show("Test");*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_v1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar_v1.Visible = false;
            restaurar_v1.Visible = true;
        }

        private void restaurar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar_v1.Visible = false;
            maximizar_v1.Visible = true;
        }

        private void minimizar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
