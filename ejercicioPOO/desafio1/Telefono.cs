using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        //Atributos y propiedades
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }

        private int codigoOperador;
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (codigoOperador >= 1 && codigoOperador <= 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }
        //Constructor
        public Telefono(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string LLamar(string contacto)
        {
            return "LLamando a " + contacto;
        }
    }
}
