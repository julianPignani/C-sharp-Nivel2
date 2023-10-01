using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;



namespace negocio
{
    public class PokemonNegocio
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
                comando.CommandText = "Select Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id  From POKEMONS P ,ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.Connection = conexion;
                conexion.Open();
                lector= comando.ExecuteReader();

                //Con un while vamos pasando por las lineas de la tabla hasta que no alla mas datos
                while(lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //Validamos la urlImagen por si esta null (Sirve para cualquier columna que no puede ser null)
                    if(!(lector["UrlImagen"] is DBNull)) //si no es null
                        aux.UrlImagen = (string)lector["UrlImagen"];
     
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
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

        //Metodo para modificar el pokemon
        public void modificar(Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad where Id = @id");
                datos.setearParametros("@numero", poke.Numero);
                datos.setearParametros("@nombre",poke.Nombre);
                datos.setearParametros("@desc",poke.Descripcion);
                datos.setearParametros("@img",poke.UrlImagen);
                datos.setearParametros("@idTipo",poke.Tipo.Id);
                datos.setearParametros("@idDebilidad",poke.Debilidad.Id);
                datos.setearParametros("@id",poke.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Pokemon nuevo) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //llamamos a los metodos para enviar la consulta
                //y para ejecutar la accion.
                datos.setearQuery("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen)values("+ nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, @idTipo, @idDebilidad, @urlImagen )");
                datos.setearParametros("@idTipo", nuevo.Tipo.Id); //llamamos al metodo setearParametros
                datos.setearParametros("@idDebilidad", nuevo.Debilidad.Id);//para pasarle lso id, Otra forma de realziar consultas
                datos.setearParametros("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
