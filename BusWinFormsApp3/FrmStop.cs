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
using CapaNegocio;
using CapaEntidades;

namespace BusWinFormsApp3
{
    public partial class FrmStop : Form
    {
        public string Rol;
        B_Informacion info = new B_Informacion();
        E_InformacionDriver driver = new E_InformacionDriver();
        public FrmStop()
        {
            InitializeComponent();
        }
        /*private void ActualizarEstadoConductor()
        {

            /*SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
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
        }*/
        private void Todo()
        {
           
            
                try
                {

                     
                    if (Rol == "USUARIO")
                    {
                        driver.Cedula = txtCedula.Text;
                        info.ActualizaTodo(driver);
                        MessageBox.Show("Conductor en Stop");




                    }
                    if (Rol=="ADMINISTRADOR")
                    {
                        MessageBox.Show("Esta Cedula pertenece a un administrador ");
                    }

                }
                catch (Exception)
                {

                    throw;
                }
               
            
            




        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Todo();
            txtCedula.Text = "";

        }

        private void FrmStop_Load(object sender, EventArgs e)
        {
            Rol = DataStatic.Rol;
        }
    }
}
