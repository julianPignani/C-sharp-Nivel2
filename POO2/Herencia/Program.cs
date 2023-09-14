using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lider lider = new Lider("Julián", "Pignani", "Liderar el equipo, ayudando en la toma de decisiones");
            Persona qa = new Tester("Manuel","Ramirez","Revisar el codigo");
            Persona dev = new Developer("Martin","Gonzalez","Encargado de desarrollar la app.");

            Console.WriteLine(lider.MostrarDatos());
            Console.WriteLine(qa.MostrarDatos());
            Console.WriteLine(dev.MostrarDatos());

            Console.ReadKey();
        }
    }
}
