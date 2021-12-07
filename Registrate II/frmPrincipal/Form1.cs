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

namespace frmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            string nombre = tb_Nombre.Text;
            string direccion = tb_Direccion.Text;
            int edad = (int)num_Edad.Value;         
            string genero = "";
            string pais = lb_Paises.GetItemText(lb_Paises.SelectedItem);

            //creo un array para guardar los cursos chequeados
            string[] cursos = new string[3];
            int posicion = 0;
            foreach (CheckBox item in gb_Cursos.Controls)
            {
                if (item.Checked)
                {
                    cursos[posicion] = item.Text;
                    posicion++;
                }
            }

            foreach (RadioButton item in gb_Genero.Controls)
            {
                if (item.Checked)
                {
                    genero = item.Text;
                }
            }

            Ingresante persona = new Ingresante(nombre, direccion, genero, pais, cursos, edad);

            MessageBox.Show($"{persona.Mostrar()}");
        }
    }
}
