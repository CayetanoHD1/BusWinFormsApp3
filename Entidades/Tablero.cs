using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Tablero
    {
        private string conductor;
        private string bus;
        private string rutaD;
        private string rutaO;

        public string Conductor { get => conductor; set => conductor = value; }
        public string Bus { get => bus; set => bus = value; }
        public string RutaD { get => rutaD; set => rutaD = value; }
        public string RutaO { get => rutaO; set => rutaO = value; }
    }
}
