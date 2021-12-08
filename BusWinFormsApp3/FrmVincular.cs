using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace BusWinFormsApp3
{
    public partial class FrmVincular : Form
    {
        /* SqlConnection cn;
         SqlCommand cmd;
         SqlDataReader dr ,daa;
         SqlDataAdapter da;
         DataTable dt;*/
        B_Informacion entra = new B_Informacion();
      

        public FrmVincular()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadCombo()
        {

            

             /*   SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from Usuarios where Estado=1 and Rol='Usuario'"

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cmb_chofer.Items.Add($"{dr["Nombre"].ToString()} {dr["Apellido"].ToString()}-{dr["id"].ToString()} ");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }*/
        }

        private void LoadComboRuta()
        {

            /*SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from Rutas where Estado=1";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cmb_ruta.Items.Add($"{dr["Ruta"].ToString()}-{dr["Id"]}");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }*/
        }

        private void LoadComboBus()
        {

           /* SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from AutoBuses where Estado=1";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cmb_autobus.Items.Add($"{dr["Marca"].ToString()} {dr["Modelo"].ToString()}-{dr["id"].ToString()}");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }*/
        }

        private void ActualizarEstadoConductor()
        {
           /* string Chofer = Cmb_chofer.Text.Split("-")[1];
             

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {
                
                con.Open();
                cmd = con.CreateCommand();
               
                cmd.CommandText = "Update Usuarios set Estado = 2 where id = "+Convert.ToInt32(Chofer);

                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }*/
        }


       /* private void InsertarEnTabla()
        {
           /* string Chofer = Cmb_chofer.Text.Split("-")[1];
            string Ruta = Cmb_ruta.Text.Split("-")[1];
            string Bus = Cmb_autobus.Text.Split("-")[1]; 

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
             
            try
            {
                
                SqlCommand comando = new SqlCommand("SP_Insertar", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Chofer", Convert.ToInt32(Chofer));
                comando.Parameters.AddWithValue("@Rutas", Convert.ToInt32(Ruta));
                comando.Parameters.AddWithValue("@Autobus", Convert.ToInt32(Bus));
                MessageBox.Show("Conductor Añadido");

                comando.ExecuteNonQuery();
                con.Close();

                
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
            con.Close();

        } */
       /* private void ActualizarEstadoRutas()
        {
     
            string Ruta = Cmb_ruta.Text.Split("-")[1];
           

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Rutas set Estado = 2 where id = " +Convert.ToInt32(Ruta);
                

                cmd.ExecuteNonQuery();

        
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }        con.Close();
        }

        private void ActualizarEstadoBus()
        {
         
            string Bus = Cmb_autobus.Text.Split("-")[1];

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Autobuses set Estado = 2 where id = " + Convert.ToInt32(Bus);

                cmd.ExecuteNonQuery();

                
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }con.Close();
        }*/
        private void clear()
        {
            Cmb_autobus.SelectedText = null;
            Cmb_chofer.SelectedText = null;
            Cmb_ruta.SelectedText = null;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            var result =  entra.load("SP_Conductor_Load");
            foreach (var item in result)
            {
                Cmb_autobus.Items.Add(item);
            }
            
            
            
            
        }
        public void MostrarBusqueda(string buscar)
        {
            B_Informacion cap = new B_Informacion();
            Tabla.DataSource = cap.lista(buscar);
           






        }
        public void ModerTable()
        {
           /* Tabla.Columns[0].Width = 58;
            Tabla.Columns[1].Width = 10;
            Tabla.Columns[2].Width = -20;
            Tabla.Columns[3].Width = 0;
            Tabla.Columns[4].Width = 80;*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
          /*  ActualizarEstadoBus();
            ActualizarEstadoConductor();
            ActualizarEstadoRutas();
            InsertarEnTabla();*/
            clear();
           //LoadCombo();
            /*LoadComboBus();
            LoadComboRuta();*/
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_autobus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
