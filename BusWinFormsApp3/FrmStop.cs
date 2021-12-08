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
    public partial class FrmStop : Form
    {
        SqlCommand cmd;
        public FrmStop()
        {
            InitializeComponent();
        }
        private void ActualizarEstadoConductor()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {
                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Cedula en Blanco");

                }
                

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Usuarios set Estado = 1, Rol= 'Usuario' where Cedula ='" + txtCedula.Text+"'";
             


                cmd.ExecuteNonQuery();
                MessageBox.Show("Bus en Stop");

                con.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void Todo()
        {
            string id = txtCedula.Text;

            SqlConnection cont = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");

            try
            {

                SqlCommand comando = new SqlCommand("LOGICREFRESH", cont);
                comando.CommandType = CommandType.StoredProcedure;
                cont.Open();
               /* comando = cont.CreateCommand();
                comando.CommandText = "exec SP_Insertar";
                comando.CommandType = CommandType.StoredProcedure;*/
                comando.Parameters.AddWithValue("@cedula",id);
                
                

                comando.ExecuteNonQuery();
                cont.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
           

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActualizarEstadoConductor();
            Todo();


        }
    }
}
