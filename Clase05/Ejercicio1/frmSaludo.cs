using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class frmSaludo : Form
    {
        public frmSaludo(string titulo, string mensaje)
        {

            InitializeComponent();

            lblTitulo.Text = titulo;
            lblSaludo.Text = mensaje;           
        }

        private void frmSaludo_Load(object sender, EventArgs e)
        {

        }
    }
}
