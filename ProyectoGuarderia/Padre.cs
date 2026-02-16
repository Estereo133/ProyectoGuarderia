using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Necesario para manejar archivos
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGuarderia
{
    public partial class Form_Padre : Form
    {
        public Form_Padre()
        {
            InitializeComponent();
        }

        private void pbPadre_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Quieres subir o modificar la imagen?",
               "Subir Imagen",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagenes|*.jpg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Carpeta relativa dentro de la aplicación
                    string carpeta = Path.Combine(Application.StartupPath, "ImagenesPadres");

                    // Crear la carpeta si no existe
                    Directory.CreateDirectory(carpeta);

                    // Generar un nombre único para la imagen
                    string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);
                    string rutaDestino = Path.Combine(carpeta, nombreArchivo);

                    // Copiar la imagen seleccionada a la carpeta
                    File.Copy(ofd.FileName, rutaDestino, true);

                    // Mostrar la imagen en el PictureBox
                    pbPadre.Image = Image.FromFile(rutaDestino);

                    // Aquí podrías guardar el nombreArchivo en una variable o lista
                    // para luego relacionarlo con el padre cuando implementes la BD.
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtAmaterno_TextChanged(object sender, EventArgs e) { }
        private void txtApaterno_TextChanged(object sender, EventArgs e) { }
        private void txtTelefono_TextChanged(object sender, EventArgs e) { }
        private void txtOcupacion_TextChanged(object sender, EventArgs e) { }
        private void txtGradoEstudios_TextChanged(object sender, EventArgs e) { }
    }
}