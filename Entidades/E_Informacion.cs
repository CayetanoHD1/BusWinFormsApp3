using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Informacion
    {
        private string  id;
        private string nombre;
        private string placa;
        private string ruta;
        private string estado;
        private string cedula;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}
