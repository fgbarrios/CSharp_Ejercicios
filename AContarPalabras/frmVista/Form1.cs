using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmVista
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = ObtenerContadorPalabras();

            // creo un lista llamada PODIO para almacenar todos los datos del diccionario. Uso el metodo ToList.
            List<KeyValuePair<string, int>> podio = diccionario.ToList();

            // uso el metodo Sort de las listas.
            podio.Sort(CompararCantidadRepeticiones);

            // muestro el podio
            MostrarPodio(podio);
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if (podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras.");
            }
            else 
            {
                // muestro las primeras 3. Valido por las primeras 3 y menos en caso de que Count sea menos que 3
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} Cantidad: {par.Value}");
                }
              
            }         

            MessageBox.Show(sb.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, 
            KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        /*
            Se deberá recorrer el texto ingresado palabra por palabra.
            Si se trata de una nueva palabra, se la agregará al diccionario
            y se inicializará su contador en 1.
            Caso contrario, se deberá incrementar dicho contador.
            */
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string textoIngresado = richTextBox1.Text.ToLower();
            string[] textoSeparado = textoIngresado.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (string palabra in textoSeparado)
            {
                if (diccionario.ContainsKey(palabra))
                {
                    // con ++ puedo incrementar el VALUE directamente usando la key como indice
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }

            }
            return diccionario;
        }
    }
}
