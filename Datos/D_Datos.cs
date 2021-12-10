using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Xceed.Wpf.Toolkit;
 

namespace CapaDatos
{
   public class D_Datos
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conector"].ConnectionString);
        SqlCommand cmd;
        public List<E_Informacion> ListarInformacion(string buscar)
        {
            SqlDataReader read;
            SqlCommand cdm = new SqlCommand("SP_Cargar", co );
            cdm.CommandType = CommandType.StoredProcedure;
            co.Open();
            cdm.Parameters.AddWithValue("@Buscar", buscar);
            read = cdm.ExecuteReader();


            List<E_Informacion> listar = new List<E_Informacion>();

            while (read.Read())
            {
                listar.Add(new E_Informacion
                {


                    Id = read.GetString(0),
                    Nombre = read.GetString(1),
                    Cedula = read.GetString(2),
                    Placa = read.GetString(3),
                    Ruta = read.GetString(4),
                    Estado= read.GetString(5)


                });



            }
            co .Close();
            read.Close();

            return listar;
        }
        public E_informacion2 loginn(string Correo, string Pass, string Rol )
        {
            co.Close();
            SqlDataReader read2;
            SqlCommand comando = new SqlCommand("SP_Login", co);
            comando.CommandType = CommandType.StoredProcedure;
            co.Open();
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Clave", Pass);
            comando.Parameters.AddWithValue("@Rol",Rol);
             
            read2 = comando.ExecuteReader();


            if (read2.Read())
            {
                E_informacion2 inf = new E_informacion2();
                inf.Nombre = read2.IsDBNull(2) ? "" : read2.GetString(2);
                inf.Rol = read2.IsDBNull(8) ? "" : read2.GetString(8);



                return inf;




            }
            else 
            {
                return null;
            }
            read2.Close();
             

        }
        public E_informacion2 CheckRol( string Rol)
        {
            co.Close();
            SqlDataReader read2;
            SqlCommand comando = new SqlCommand("SP_Roll", co);
            comando.CommandType = CommandType.StoredProcedure;
            co.Open();
            comando.Parameters.AddWithValue("@Rol", Rol);

            read2 = comando.ExecuteReader();


            if (read2.Read())
            {
                E_informacion2 inf = new E_informacion2();

                inf.Rol = read2.IsDBNull(8) ? "" : read2.GetString(8);



                return inf;




            }
            else
            {
                return null;
            }
            read2.Close();


        }
        public void AddRuta(E_InformacionR ruta)
        {
            co.Close();
            SqlCommand cmd = new SqlCommand("SP_Insert_Ruta", co);
            cmd.CommandType = CommandType.StoredProcedure;
            co.Open();
            cmd.Parameters.AddWithValue("@Ruta", ruta.Ruta);
            cmd.ExecuteNonQuery();


           




        }
        public void infoBus(E_InformacionBus bus)
        {
            co.Close();
            SqlCommand comando = new SqlCommand("SP_Autobus_Inserts", co);
            comando.CommandType = CommandType.StoredProcedure;
            co.Open();
            comando.Parameters.AddWithValue("@Marca ", bus.Marca);
            comando.Parameters.AddWithValue("@Modelo", bus.Modelo);
            comando.Parameters.AddWithValue("@Placa ", bus.Placa);
            comando.Parameters.AddWithValue("@Year", bus.Año);
            comando.Parameters.AddWithValue("@Color ", bus.Color);
            comando.ExecuteNonQuery();

        }
        

        public List<string> loadData(string procedure)
        {
            var lista = new List<string> ();
            co.Close();

            co.Open();
            SqlCommand con = new SqlCommand(procedure, co);
            con.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = con.ExecuteReader();
            
            while(dr.Read())
            {
                var item = $"{dr["marca"].ToString()}  {dr["placa"].ToString() }-{dr["id"].ToString()}";
                lista.Add(item);
            }

            co.Close();
            dr.Close();
            return lista;
        }
        public List<string> loadRuta(string procedure)
        {
            var listar = new List<string>();
            co.Close();

            co.Open();
            SqlCommand conn = new SqlCommand(procedure, co);
            conn.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = conn.ExecuteReader();

            while (dr.Read())
            {
                var item = $"{dr["Ruta"].ToString()}-{dr["id"].ToString()} ";
                listar.Add(item);
            }

            co.Close();
            dr.Close();
            return listar;
        }
        public List<string> loadChofer(string procedure)
        {
            var listar = new List<string>();
            co.Close();

            co.Open();
            SqlCommand conn = new SqlCommand(procedure, co);
            conn.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = conn.ExecuteReader();

            while (dr.Read())
            {
                var item = $" {dr["Nombre"].ToString()} {dr["Apellido"].ToString()}-{dr["id"].ToString()}";
                listar.Add(item);
            }

            co.Close();
            dr.Close();
            return listar;
        }
        


        public void insertDriver(E_InformacionDriver inf)
        {
            co.Close();
  
            SqlCommand comando = new SqlCommand("SP_driver_Insert", co);
            comando.CommandType = CommandType.StoredProcedure;
            co.Open();
            comando.Parameters.AddWithValue("@Nombre", inf.Nombre);
            comando.Parameters.AddWithValue("@Apellido", inf.Apellido);
            comando.Parameters.AddWithValue("@Correo", inf.Correo);
            comando.Parameters.AddWithValue("@Clave", inf.Clave);
            comando.Parameters.AddWithValue("@Cedula", inf.Cedula);
            comando.Parameters.AddWithValue("@Nacimiento", inf.Nacimiento);
            comando.Parameters.AddWithValue("@Rol", inf.Rol);
            comando.ExecuteNonQuery();



        }
        public E_InformacionDriver checkDriver(string Correo, string Cedula)
        {

            
            try
            {
                co .Open();
                SqlDataReader LeerDatos;
                SqlCommand comando = new SqlCommand("SP_RevisarD",co );
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Cedula", Cedula);

               

                  LeerDatos = comando.ExecuteReader();
                E_InformacionDriver datos = new E_InformacionDriver();

                if (LeerDatos.Read())
                {
                 
                    datos.Correo = LeerDatos.IsDBNull(4) ? "" : LeerDatos.GetString(4);
                   datos.Cedula = LeerDatos.IsDBNull(6) ? "" : LeerDatos.GetString(6);
                    
               
                    co.Close();
                    return datos;
                }
               
                else
                {
                    co.Close();
                    return null;
                }

            }
            catch (Exception x)
            {
                co.Close();

                return null;
            }





        }
        public E_InformacionBus checkBus( string Placa)
        {
            co.Close();
            SqlDataReader reader;
            SqlCommand comando = new SqlCommand("SP_CheckBus", co);
            comando.CommandType = CommandType.StoredProcedure;
            co.Open();
            
            comando.Parameters.AddWithValue("@Placa", Placa);

            reader = comando.ExecuteReader();


            if (reader.Read())
            {
                E_InformacionBus add = new E_InformacionBus();
                add.Placa = reader.IsDBNull(3) ? "" : reader.GetString(3);
          
                



                return add;




            }
            else
            {
                return null;
            }
            reader.Close();


        }
       public void Insertartabla(E_Vincular vincular)
        {
            try
            {

                SqlCommand comando = new SqlCommand("SP_Vincular", co);
                comando.CommandType = CommandType.StoredProcedure;
                co.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Chofer", Convert.ToInt32(vincular.Chofer));
                comando.Parameters.AddWithValue("@Bus", Convert.ToInt32(vincular.Autobus));
                comando.Parameters.AddWithValue("@Ruta", Convert.ToInt32(vincular.Ruta));
                comando.Parameters.AddWithValue("@Estados", Convert.ToInt32(2));



                comando.ExecuteNonQuery();
                co.Close();


            }

            catch (Exception ex)
            {
                 
            }
            


        }
        public void UpdateusUario(E_Vincular ad)
        {   co.Close();
            SqlCommand command = new SqlCommand("SP_ActualizarU",co);
            command.CommandType = CommandType.StoredProcedure;
            
            co.Open();
            command.Parameters.AddWithValue("@id", Convert.ToInt32(ad.Id));
            command.ExecuteNonQuery();
            
        }
        public void UpdateusRuta(E_InformacionR ad)
        {
            co.Close();
            SqlCommand command = new SqlCommand("SP_ActualizarR", co);
            command.CommandType = CommandType.StoredProcedure;

            co.Open();
            command.Parameters.AddWithValue("@id", Convert.ToInt32(ad.Id));
            command.ExecuteNonQuery();

        }
        public void UpdateusBus(E_InfromacionB add)
        {
            co.Close();
            SqlCommand command = new SqlCommand("SP_ActualizarB", co);
            command.CommandType = CommandType.StoredProcedure;

            co.Open();
            command.Parameters.AddWithValue("@id", Convert.ToInt32(add.Id));
            command.ExecuteNonQuery();

        }
        public Tablero DashboardDatos(Tablero carga)
        {
            cmd = new SqlCommand("SP_Count", co);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totalRuta = new SqlParameter("@totConductor", 0); totalRuta.Direction = ParameterDirection.Output;
            SqlParameter totalBus = new SqlParameter("@totBus", 0); totalBus.Direction = ParameterDirection.Output;
            SqlParameter totRutaD = new SqlParameter("@totRutaD", 0); totRutaD.Direction = ParameterDirection.Output;
            SqlParameter totRutaO = new SqlParameter("@totRutaO", 0); totRutaO.Direction = ParameterDirection.Output;
           
            cmd.Parameters.Add(totalRuta);
            cmd.Parameters.Add(totalBus);
            cmd.Parameters.Add(totRutaD);
            cmd.Parameters.Add(totRutaO);
           
            co.Open();
            cmd.ExecuteNonQuery();
            carga.Conductor = cmd.Parameters["@totConductor"].Value.ToString();
            carga.Bus = cmd.Parameters["@totBus"].Value.ToString();
            carga.RutaD = cmd.Parameters["@totRutaD"].Value.ToString();
            carga.RutaO = cmd.Parameters["@totRutaO"].Value.ToString();

            return carga;
            
        }
        public void TodoStop(E_InformacionDriver dr)
        {
            co.Close();
            SqlCommand cdm = new SqlCommand("SP_General",co);
            cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@Cedula", dr.Cedula);
            co.Open();
            cdm.ExecuteNonQuery();

        }
    }
}

