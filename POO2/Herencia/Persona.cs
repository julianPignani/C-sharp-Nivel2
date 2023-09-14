using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //Clase abstacta
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  Funcion { get; set; }

        public Persona(string nombre, string apellido, string funcion) {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Funcion = funcion;
        }
        //sobreescritura de metodo, utilizando la palabra reservada "virtual"
        public virtual string MostrarDatos()
        {
            return Nombre + " " + Apellido + ", roll a cumplir: " + Funcion;
        }
    }
}
