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
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class FrmListaSuper : Form
    {
        //Tendrá un atributo listaSupermercado de tipo List<string> que contendrá los elementos de la lista del supermercado.
        private List<string> listaSupermercado;
        private string rutaArchivo;

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            /*En el manejador del evento Load se deberá buscar el archivo listaSupermercado.xml 
             * en la carpeta de datos de aplicaciones (Environment.SpecialFolder.ApplicationData) 
             * y, si existe, deserializarla desde formato XML como una lista de string.
            Cargar lstObjetos con los elementos de la lista.
            Si el archivo no existe, no hacer nada.
             */

            string rutaAplicaciones = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            rutaArchivo = Path.Combine(rutaAplicaciones, "listaSupermercado.xml");

            if (File.Exists(rutaArchivo))
            {
                CargarDatos(rutaArchivo);
                ActualizarListBox();
            }           

        }

        private void GuardarDatos()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSupermercado);
            }

        }

        private void CargarDatos(string rutaArchivo)
        {
            using (StreamReader streamWriter = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());

                // xmlDeserialize devuelve un objeto, por eso el casteo. Si no lo puede hacer, devuelve null
                listaSupermercado = xmlSerializer.Deserialize(streamWriter) as List<string>;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Al accionarlo instanciará un FrmAltaModificacion y lo mostrará de forma modal.
            El título será "Agregar objeto".
            El contenido del txtObjeto será un texto vacío.
            El texto del btnConfirmar será "Agregar".
             * */

            FrmAltaModificacion altaModificacion = new FrmAltaModificacion("Agregar item a comprar", string.Empty, "Agregar");
            // muestro en forma modal
            altaModificacion.ShowDialog();

            if (altaModificacion.DialogResult == DialogResult.OK)
            {
                // valido que no se intente agregar un item que ya esta en la lista
                string nuevoObjeto = altaModificacion.Objeto;

                if (listaSupermercado.Contains(nuevoObjeto))
                {
                    MessageBox.Show("El objeto ya esta en la lista", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // agrego a la lista el item
                    listaSupermercado.Add(altaModificacion.Objeto);
                    // Guardo los datos en XML
                    GuardarDatos();

                    // y los muestro en el list box
                    ActualizarListBox();
                }                                
            }
        }

        private void ActualizarListBox()
        {
            listObjetos.DataSource = null;
            listObjetos.DataSource = this.listaSupermercado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Al accionarlo deberá borrar el objeto seleccionado en la lista.
            //Si no hay nada seleccionado, no hacer nada y mostrar un cartel informando que se debe seleccionar
            //un elemento de la lista.

            string itemSeleccionado = listObjetos.SelectedItem as string;
            if (itemSeleccionado is not null)
            {
                listaSupermercado.Remove(itemSeleccionado);
                GuardarDatos();
                ActualizarListBox();                
                                    
            }else
            {
                MessageBox.Show("Debe seleccionar un item a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string itemSeleccionado = listObjetos.SelectedItem as string;

            if (itemSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar un item a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmAltaModificacion altaModificacion = new FrmAltaModificacion("Modificar Objeto", itemSeleccionado, "Modificar");
                // muestro en forma modal
                altaModificacion.ShowDialog();

                if (altaModificacion.DialogResult == DialogResult.OK)
                {                    
                    // modifico el item
                    string nuevoObjeto = altaModificacion.Objeto;
                    int indiceObjetoSeleccionado = listaSupermercado.IndexOf(itemSeleccionado);

                    listaSupermercado[indiceObjetoSeleccionado] = nuevoObjeto;

                    // Guardo los datos en XML y los muestro en el list box
                    GuardarDatos();                    
                    ActualizarListBox();                    
                }
            }            
        }
    }
}
