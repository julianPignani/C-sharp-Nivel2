﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();//llamamos al constructor donde se conecta la bd
            try
            {
                //generamos la consulta sobre la tabla elementos
                datos.setearQuery("select Id, Descripcion From ELEMENTOS");
                datos.ejecutarQuery();
               
                while(datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id =(int) datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
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
