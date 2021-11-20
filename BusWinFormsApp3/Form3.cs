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
    public partial class ventana5 : Form
    {
        public ventana5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
        public void save()
        {
            try
            {
                con.Open();
                var qry = "insert into Autobuses ([Marca] ,[Modelo] ,[Placa] ,[Color] ,[Years])" +
                  "values ('"+txt_marca.Text+"','"+txt_modelo.Text+"','"+txt_placa.Text+"','"+txt_color.Text+"','"+txt_año.Text+"')";
                SqlCommand cdm = new SqlCommand(qry, con);
               
                MessageBox.Show("AutoBus Agregado Exitosamente");
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

        private void restaurar_v2_Click(object sender, EventArgs e)
        {
            
        }

        private void maximizar_v2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            save();
            txt_año.Text = "";
            txt_color.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_placa.Text = "";

        }

        private void cerrar_v2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void maximizar_v3_Click(object sender, EventArgs e)
        {

        }

        private void ventana5_Load(object sender, EventArgs e)
        {

        }
    }
}
