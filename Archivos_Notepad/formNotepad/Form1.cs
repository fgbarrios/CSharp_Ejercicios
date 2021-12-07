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

namespace formNotepad
{
    public partial class frmNotePad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;

        public frmNotePad()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }

        private void frmNotePad_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "0 Caracteres";
        }

        private void rch_Main_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Text = $"{rch_Main.Text.Length} Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Archivos -> Abrir
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;

                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        rch_Main.Text = sr.ReadToEnd();
                    }

                }
                catch (Exception ex)
                {

                    MostrarMensajeError(ex);
                }
            }
        }

        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Archivos -> Guardar
            if (!File.Exists(archivo)) // valido si el archivo existe
            {
                // si no existe, hacemos guardar con dialog (porque no tenemos ninguna ruta de archivo)
                GuardarArchivoConDialog();
            }
            else
            {
                // si el archivo existe, lo pasamos directamente a guardar.
                GuardarArchivo(archivo);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Archivos -> Guardar Como...
            GuardarArchivoConDialog();
        }

        private void GuardarArchivoConDialog()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;

                GuardarArchivo(archivo);

            }
        }

        private void GuardarArchivo(string archivo) 
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(archivo))
                {
                    sr.Write(rch_Main.Text);
                }

            }
            catch (Exception ex)
            {

                MostrarMensajeError(ex);
            }
        }

        private void statusLabel_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
