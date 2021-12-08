using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_InformacionDriver
    {
       private string nombre;
        private string apellido;
        private string correo;
        private string clave ;
        private string cedula ;
         private DateTime nacimiento;
        private string rol ;
 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Rol { get => rol; set => rol = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }

    }
}
