using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;//agregar
using negocio;//agregar

namespace Conexion_DB
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        //btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Con esto cancela todo
        }
        //btnAceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //instanciamos las dos clases
            Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                //traemos los datos de la ventana
                poke.Numero = int.Parse(txtNumero.Text);
                poke.Nombre = txtNombre.Text;
                poke.Descripcion = txtDescripcion.Text;
                poke.UrlImagen = txtUrlImagen.Text;

                //capturamos lo que viene en el comboBox
                poke.Tipo = (Elemento)cboTipo.SelectedItem;
                poke.Debilidad =(Elemento) cboDebilidad.SelectedItem;

                //llamamos al la funcion agregar de pokemonNegocio
                negocio.agregar(poke);
                MessageBox.Show("Agregado exitosamente");
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
                cboDebilidad.DataSource = elementoNegocio.listar();

                //luego de esto, tenemos q capturarlo en el btnAceptar
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
    }
}
