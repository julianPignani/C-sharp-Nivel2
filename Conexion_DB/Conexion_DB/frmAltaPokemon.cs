using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;//agregar
using negocio;//agregar
using System.Configuration;

namespace Conexion_DB
{
    public partial class frmAltaPokemon : Form
    {
        //Cuando vos toques agregar esto se pone null, pero cuando tocamos modificar
        //Nos manda al constructor que creamos
        private Pokemon pokemon = null;

        private OpenFileDialog archivo = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        //Creamos el constructor para modificar
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        //btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Con esto cancela todo
        }
        //btnAceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //instanciamos la  clase
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                //Si el pokemon esta null, significa que vamos a crear un pokemon, sino
                //lo que hace es modificar el existente
                if (pokemon == null)
                    pokemon = new Pokemon();
                //traemos los datos de la ventana
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;

                //capturamos lo que viene en el comboBox
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad =(Elemento) cboDebilidad.SelectedItem;


                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    //llamamos al la funcion agregar de pokemonNegocio
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                //Guardo la imagen si la levantó localmente
                if(archivo != null)
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //metodo desde el load, para trabajar con los comboBox desde la BD
        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            //instanciamos la clase
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                //llamamos al metodo listar de la clase ElementoNegocio
                //para que nos traiga los datos de la tabla elemento.
                //y los muestre en el desplegable del comboBox de la app.
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id"; //Con esto hacemos q nos apareza el tipo
                cboTipo.DisplayMember = "Descripcion"; //y la debilidad del pokmeon seleccionado
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                //luego de esto, tenemos q capturarlo en el btnAceptar/btnModificar
                if(pokemon != null)//Si pokemon es diferente de null, significa q modificamos
                {
                    //Mostramos los datos del pokemon a modificar
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                        

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Metodo leave del txtUrlImagen para cargarle la url y que muestre la imagen
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        //Tener en cuenta q este metodo de cargar imagen ya esta en otra clase tmb
        //Lo ideal seria crear una funcion afuera y llamarla en ambas clases
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }

        }
        //Evento para levantar una imagen desde un archivo
        private void btnLevantarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //Guardo la imagen en el evento aceptar
                // tener en cuenta de agregar la ruta en la configuracion
                

            }

        }
    }
}
