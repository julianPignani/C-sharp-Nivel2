using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public int Modelo { get; set; }
        public string Marca { get; set; }

        public Vehiculo(string color, int modelo, string marca) {
            this.Color = color;
            this.Modelo = modelo;
            this.Marca = marca; 

        }
    }
}
