using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms; //incluir libreria

namespace Conexion_DB
{
    internal class PokemonNegocio
    {
        //Creamos el metodo listar
        public List<Pokemon> listar()
        {
            //Creamos la conexion, el comando y el lector
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Configuramos
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database= POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P ,ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.Connection = conexion;
                conexion.Open();
                lector= comando.ExecuteReader();

                //Con un while vamos pasando por las lineas de la tabla hasta que no alla mas datos
                while(lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }
                //Esto no iria aca, pero por ahora lo usamos asi
                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
