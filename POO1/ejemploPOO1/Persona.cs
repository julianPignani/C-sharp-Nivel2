using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPOO1
{
    internal class Persona
    {
        //Atributos
        private string nombre;
        private int edad;
        private string direccion;

        //Propiedad
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
