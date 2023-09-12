using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Agenda
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NumeroTelefonico { get; set; }
        public bool GuardarEnMemoria { get; set; }

        public Agenda(string nombre, string apellido, string numeroTelefonico, bool guardarEnMemoria)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroTelefonico = numeroTelefonico;
            GuardarEnMemoria = guardarEnMemoria;
        }
        public string MostrarDatos()
        {
            return "Contacto: " + Nombre + " " + Apellido + " y su teléfono: " + NumeroTelefonico + ",guardado en memoria: " + GuardarEnMemoria; 
        }

    }
}
