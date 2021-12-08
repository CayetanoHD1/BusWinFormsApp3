using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_informacion2
    {
        private string correo;
        private string pass;
        private string nombre;
        private string rol;
        public string Correo { get => correo; set => correo = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
