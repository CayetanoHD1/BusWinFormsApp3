using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{


    public class B_Informacion
    {
        D_Datos cap = new D_Datos();

        public List<E_Informacion> lista(string buscar)
        {
            return cap.ListarInformacion(buscar);
        }
        public E_informacion2 logger(string Correo, string Pass, string Rol)
        {
            return cap.loginn(Correo, Pass, Rol);
        }
        public void insertandoRuta(E_InformacionR ruta)
        {
            cap.AddRuta(ruta);
        }

        public void insertandoBus(E_InformacionBus bus)
        {
            cap.infoBus(bus);
        }
        public void insertandoDriver(E_InformacionDriver driver)
        {
            cap.insertDriver(driver);

        }
        public E_InformacionDriver driverCheck(string Correo, string Cedula)
        {
            return cap.checkDriver(Correo, Cedula);
        }
        public E_InformacionBus chekarBus(string Placa)
        {
            return cap.checkBus(Placa);
        }
        public List<string> load(string procedure)
        {
            return cap.loadData(procedure);
        }
        
    }
}
