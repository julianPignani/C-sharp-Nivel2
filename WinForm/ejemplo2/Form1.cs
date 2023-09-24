using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColorFavorito.Items.Add("Rojo");
            cbColorFavorito.Items.Add("Amarillo");
            cbColorFavorito.Items.Add("verde");
            cbColorFavorito.Items.Add("Celeste");

        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;

            //Utilizo operador ternario para el check box
            string alergico = cbAlergico.Checked == true ? "Es alergico" : "No es alergico";

            //Con un if resuelvo el radio button
            string tipo;
            if (rbtMasculino.Checked == true)
                tipo = "Masculino";
            else if (rbtFemenino.Checked == true)
                tipo = "Femenino";
            else
                tipo = "Indistinto";

            //Value porq tree un entero y lo convertimos en string
            string edad = nudEdad.Value.ToString();

            string colorFavorito = cbColorFavorito.SelectedItem.ToString();

            string mensaje = "Nombre: " + nombre + ",Fecha nacimiento: " + fecha.ToString("dd/MM/yyyy") + ",Alergico?: " + alergico +
                ",sexo: " + tipo + ", edad: " + edad + ", Color favorito: " + colorFavorito;

            MessageBox.Show(mensaje);


        }
    }
}
