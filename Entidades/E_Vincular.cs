using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vincular
    {
        private string chofer;
        private string ruta;
        private string autobus;
        private string id;

        public string Chofer { get => chofer; set => chofer = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Autobus { get => autobus; set => autobus = value; }
        public string Id { get => id; set => id = value; }
    }
}
