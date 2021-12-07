using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace frmVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // carga el numericupdown numEdad con valores del 0 al 100
            numEdad.Minimum = 0;
            numEdad.Maximum = 100;

            

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] cursos = new string[3];
            string direccion = tbxDireccion.Text;
            int edad = (int)numEdad.Value;
            string genero = string.Empty;
            string nombre = tbxNombre.Text;
            string pais = listBoxPaises.GetItemText(listBoxPaises.SelectedItem);

            int posicion = 0;

            foreach (RadioButton item in groupGenero.Controls)
            {
                if (item.Checked)                    
                   {                            
                       genero = item.Text;
                   }
            }

            foreach (CheckBox item in groupCursos.Controls)
            {
                if (item.Checked)
                {
                    cursos[posicion] = item.Text;
                    posicion++;
                }
                
            }

            //creo el nuevo ingresante
            Ingresante n1 = new Ingresante(nombre, direccion, genero, pais, cursos, edad);

            MessageBox.Show($"{n1.Mostrar()}");

        }
    }
}
