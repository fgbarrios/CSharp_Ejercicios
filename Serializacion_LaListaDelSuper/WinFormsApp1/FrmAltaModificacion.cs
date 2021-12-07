using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmAltaModificacion : Form
    {
        
        public FrmAltaModificacion(string titulo, string textoObjeto, string textoBtnConfirmar)
        {
            InitializeComponent();

            this.Text = titulo; // titulo del formulario 
            txtObjeto.Text = textoObjeto; // texto del objeto 
            btnConfirmar.Text = textoBtnConfirmar; // texto del boton Confirmar
        }


        public string Objeto 
        { 
            get 
            {
                //Tendrá una propiedad Objeto pública
                //y de sólo lectura que retornará el contenido del txtObjeto.
                return txtObjeto.Text;
             } 
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }


        private void btnConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // era dentro del text box, no del boton Confirmar
        }

        private void Confirmar()
        {
            //Validar que el txtObjeto no se encuentre vacío.
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                //Si se encuentra vacío mostrar una advertencia y no avanzar.
                MessageBox.Show("El texto esta vacio, por favor ingresar", "Campo texto vacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Si es válido, cargar la propiedad DialogResult con el valor DialogResult.OK
                //y cerrar el formulario.
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 es el código ASCII que representa a ENTER.
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27) //cancelar con ESC
            {
                Cancelar();
            }

        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
