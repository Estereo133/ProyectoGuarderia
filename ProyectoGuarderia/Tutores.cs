using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms;

namespace ProyectoGuarderia
{
    public partial class Form_Tutores : Form
    {
        private String RutaImagens = "";//ruta temporal de la imagen
        private string CarpF; // carpeta donde se guardaran todas las imagenes

        public Form_Tutores()
        {
            InitializeComponent();
            // Crear carpeta "Fotos" dentro del proyecto si no existe
            CarpF = Path.Combine(Application.StartupPath, "Fotos");
            Directory.CreateDirectory(CarpF);

            // cargaListaImagen(); no tocar no se que hago

        }

        private void Form_Tutores_Load(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;

        private void menuTimer_Tick(object sender, EventArgs e)
        {


        }

        private void MenuTutor_Click(object sender, EventArgs e)
        {
            //menuTimer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textNom_TextChanged(object sender, EventArgs e)
        {


        }

        private void texApat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAMate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void butGuar_Click(object sender, EventArgs e)
        {
            string nombre = textNom.Text;
            string Apaterno = texApat.Text;
            string Amaterno = textAMate.Text;
            string NumTele = textNUM.Text;

            string rutaGuardar = "";

            if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                string extension = Path.GetExtension(rutaImagenSeleccionada);
                string nombreArchivo = Guid.NewGuid().ToString() + extension; // Nombre único
                rutaGuardar = Path.Combine(CarpF, nombreArchivo);

                File.Copy(rutaImagenSeleccionada, rutaGuardar, true); // Guardar imagen en Fotos

                // Limpiar la selección para permitir subir otra imagen
                rutaImagenSeleccionada = "";
            }

            MessageBox.Show("La imagen se a aguardado correctamente en .\nImagen guardada en: " + rutaGuardar);




        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            //butCerrar.Enabled = false;

            this.Close();
        }

        private String rutaImagenSeleccionada = "";
        private void butImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = openFile.FileName; //se guarda en la ruat temporal
                picBoxImage.Image = Image.FromFile(rutaImagenSeleccionada); // muestra en pinture BOX
            }


        }

        private void picBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void listImag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listImag.SelectedItem != null)
            {
                string nombreArchivo = listImag.SelectedItem.ToString();
                string rutaImagen = Path.Combine(CarpF, nombreArchivo);

                if (File.Exists(rutaImagen))
                {
                    picBoxImage.Image = Image.FromFile(rutaImagen);
                }

            }
        }
    }
}
