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
        public List<string> loadR(string procedure)
        {
            return cap.loadRuta(procedure);
        }
        public List<string> loadC(string procedure)
        {
            return cap.loadChofer(procedure);
        }
        public void Insert(E_Vincular vinc)
        {
            cap.Insertartabla(vinc);

        }
        public void uptateU(E_Vincular v)
        {
            cap.UpdateusUario(v);
        }
        public void UpdateRuta(E_InformacionR R)
        {
            cap.UpdateusRuta(R);
        }
        public void UpdateBus(E_InfromacionB B)
        {
            cap.UpdateusBus(B);
        }
        public Tablero ContarU(Tablero u)
        {
         return cap.DashboardDatos(u);
        }

    }
}
