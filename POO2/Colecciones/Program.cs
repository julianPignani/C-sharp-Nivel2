using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista
            List<Camioneta> lista = new List<Camioneta>();
            lista.Add(new Camioneta("Negra", 2010, "FORD"));
            lista.Add(new Camioneta("Roja", 2020, "RAM"));
            lista.Add(new Camioneta("Blanca",2023, "Ranger"));

            //Mostramos cuantos elementos tiene.
            Console.WriteLine("La lista tiene " + lista.Count + " camionetas.");

            //Mostramos la camioneta que se encuentra en el indice 1
            Console.WriteLine("La camioneta que está en el indice 1 es: " + lista[1].Marca);

            //Eliminamos la Ranger
            lista.Remove(lista[2]);

            //Mostramos la lista por consola
            foreach (Camioneta item in lista)
            {
                Console.WriteLine("Camioneta " + item.Marca + " de color " + item.Color + " es modelo " + item.Modelo);
            }

        }
    }
}
