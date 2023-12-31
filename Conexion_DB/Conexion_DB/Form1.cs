﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;


namespace Conexion_DB
{
    public partial class btnModificar : Form
    { 

        //Creamos una lista para ir mostrando las imagenes.
        private List<Pokemon> listaPokemon;
    
        public btnModificar()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        //Mostrar las imagenes seleccionadas
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }
        //Funcion para cargar imagen, y en caso de no cargar la imagen que muestre la del catch
        private void cargarImagen(string imagen)
        {
            try
            {
                picturePokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                picturePokemon.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
           
        }
        //metodo para cargar la vista y actualizar cuando hacemos una modificacion
        private void cargar()
        {
            //instanciamos la clase y llamamos al metodo
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                ocultarColumna();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Con esto hacemos q no muestre la columna en el ventana 
        private void ocultarColumna()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog(); //para q no me permita salir de la ventana hasta terminar
            cargar();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Traemos el pokemon sleecionado para modificar
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        //funcion para eliminar/ bool logico = false significa que es un valor opcional
        //si no le pasamos nada lo toma como false y lo toma como eliminaicon fisica
        //si le pasamos true, va a tomar la eliminacion logica
        private void eliminar (bool logico = false)
        {

            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminar este Pokemon?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);
                    

                    cargar(); //para actualziar
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        //buscar a través del filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        //Evento del txtBuscar para que vaya buscando mientras vamos escribiendo
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;

            string filtro = txtFiltro.Text;
            if (filtro != "") //buscamos por el filtro
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else //si buscamos en blanco, mostramos la lista original
                listaFiltrada = listaPokemon;

            dgvPokemons.DataSource = null; //Primero limpiamos el data source y luego le asiganmos la lista
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumna();
        }
       
    }
}
