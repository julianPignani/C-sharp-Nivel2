using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    //Clase para conectarse a la base de datos para que sea reutilisable.
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
       
        //para leer el lector, creamos una propiedad
        public SqlDataReader Lector{ get { return lector; }
        }

        //Constructor a instanciar para empezar la conexion a la bd
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS01; database= POKEDEX_DB; integrated security = true");
            comando = new SqlCommand();
        }
        //Seateamos la query, le creamos la consulta.
        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //metodo que ejecuta la lectura
        public void ejecutarQuery()
        {
            comando.Connection = conexion;//se conecta
            try
            {
                conexion.Open();//Abre la bd
                lector = comando.ExecuteReader();// lee la Query
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }



    }
}
