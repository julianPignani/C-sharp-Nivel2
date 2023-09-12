using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Julián";
            p1.Edad = 27;
            p1.Direccion = "Italia 598";

            Console.WriteLine(p1.Nombre + " tiene " + p1.Edad + " años y vive en la calle " + p1.Direccion);
            Console.ReadKey();
        }
    }
}
