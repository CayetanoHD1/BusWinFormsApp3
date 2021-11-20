﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusWinFormsApp3
{
    public partial class Form4 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Form4()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadCombo()
        {

                SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from Usuarios where Estado=1";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cmb_chofer.Items.Add($"{dr["Nombre"].ToString()} {dr["Apellido"].ToString()} - {dr["id"].ToString()}");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void LoadComboRuta()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
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
                    Cmb_ruta.Items.Add($"{dr["Ruta"].ToString()}");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void LoadComboBus()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
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
                    Cmb_autobus.Items.Add($"{dr["Marca"].ToString()} {dr["Modelo"].ToString()} - {dr["id"].ToString()}");
                }

                dr.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void ActualizarEstadoConductor()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Usuarios set Estado = 2 where id = "+(int)Cmb_chofer.Items.Count;

                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }


        private void InsertarEnTabla()
        {
            int Chofer = (int)Cmb_chofer.Items.Count;
            int Ruta = (int)Cmb_ruta.Items.Count;
            int Bus = (int)Cmb_autobus.Items.Count;

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into Autobus_Rutas_Conductor values(@Chofer,@Rutas,@Autobus)";
                cmd.Parameters.AddWithValue("@Chofer",Chofer);
                cmd.Parameters.AddWithValue("@Rutas", Ruta);
                cmd.Parameters.AddWithValue("@Autobus", Bus);

                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void ActualizarEstadoRutas()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Rutas set Estado = 2 where id = " + (int)Cmb_ruta.Items.Count;

                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void ActualizarEstadoBus()
        {

            SqlConnection con = new SqlConnection("SERVER=DESKTOP-EOJG6OO\\SQLEXPRESSS;DATABASE=Login_Bus;integrated Security = true");
            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Autobuses set Estado = 2 where id = " + (int)Cmb_autobus.Items.Count;

                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadComboBus();
            LoadComboRuta();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEstadoBus();
            ActualizarEstadoConductor();
            ActualizarEstadoRutas();
            InsertarEnTabla();
            LoadCombo();
            LoadComboBus();
            LoadComboRuta();
        }
    }
}
