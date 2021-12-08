using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_InformacionBus
    {
        private string marca;
        private string  modelo;
        private string placa;
        private string año;
        private string color;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        public string Placa { get => placa; set => placa = value; }
        
    }
}
