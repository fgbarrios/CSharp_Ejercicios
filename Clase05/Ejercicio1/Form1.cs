﻿using System;
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
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            string titulo = "Hola, Windows Forms!";
            string mensaje = $"Soy {nombre} {apellido}";

            frmSaludo frmSaludo = new frmSaludo(titulo, mensaje);

            // lo muestro en forma modal
            frmSaludo.ShowDialog();
        }
    }
}
