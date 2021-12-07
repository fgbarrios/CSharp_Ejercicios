using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class frmClase05 : Form
    {
        public frmClase05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea crear un nuevo formulario?.", "Informe", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                // creo una instancia del objeto "otroForm".
                otroForm formulario2 = new otroForm();

                // ese segundo formulario lo puedo usar como cualquier otro objeto
                formulario2.Show();
                //aguardo por 2 segundos
                Thread.Sleep(2000);
                formulario2.Hide();
                Thread.Sleep(2000);
                //ventana modal (no permite ignorar)
                formulario2.ShowDialog();

                // para cerrar el formulario que instanciamos
                formulario2.Close();
                // para cerrar el formulario actual
                this.Close();
            }
        }

        private void frmClase05_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Opcion 1");
            comboBox1.Items.Add("Opcion 2");
            comboBox1.Items.Add("Opcion 3");
        }
    }
}
