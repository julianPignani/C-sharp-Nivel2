using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel = new Telefono("Iphone", "12 plus");
            tel.NumeroTelefonico = "356845";
            
            Console.WriteLine("El teléfono es: " + tel.Marca + " " + tel.Modelo + " y el nro es: " + tel.NumeroTelefonico);
            Console.WriteLine(tel.Llamar());
            Console.WriteLine(tel.LLamar("Julián"));

            Agenda miAgenda = new Agenda("Julián", "Pignani", "3472558841", true);
            Console.WriteLine(miAgenda.MostrarDatos());
            
        }
    }
}
