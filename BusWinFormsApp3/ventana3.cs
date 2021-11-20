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
    public partial class ventana3 : Form
    {
        public ventana3()
        {
            InitializeComponent();
        }
         
        SqlConnection conn = new SqlConnection("SERVER= DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
       
        public void save()
        {
            try
            {
                conn.Open();

                var date = Convert.ToDateTime(fecha.Value);
                var split = $"{date.Year}-{date.Month}-{date.Day}";


                var qry = "insert into Usuarios ([Nombre],[Apellido],[Fecha_Nacimiento],[Cedula],[Correo],[Clave],[Rol])" +
                  "values ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + split + "','" + txt_cedula.Text + "','" + txt_correo.Text + "','" + txt_pass.Text + "','" + comboBox1.SelectedText + "')";

                SqlCommand cdm = new SqlCommand(qry, conn);
                cdm.ExecuteNonQuery();
                SqlDataReader dr = cdm.ExecuteReader();
                MessageBox.Show($"{txt_nombre} Agregado Exitosamente");
               








            }
            
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
            conn.Close();

        }
        
         

        

         

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana1 lo = new ventana1();
            lo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
           /* txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_cedula.Text = "";
            txt_correo.Text = "";
            txt_pass.Text = "";
            comboBox1.SelectedItem = null;*/



        }

        private void ventana3_Load(object sender, EventArgs e)
        {

        }
    }            
}
