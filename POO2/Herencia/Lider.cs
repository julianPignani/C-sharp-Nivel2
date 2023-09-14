using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Lider : Persona
    {
        public Lider(string nombre, string apellido, string funcion) : base(nombre, apellido, funcion)
        {
        }
        //Sobreescritura de metodos
        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
