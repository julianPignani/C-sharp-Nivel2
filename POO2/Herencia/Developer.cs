using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Developer : Persona
    {
        public Developer(string nombre, string apellido, string funcion) : base(nombre, apellido, funcion)
        {
        }
        //Sobreescritura de metodos
        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
