using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProyectoGuarderia
{
    public partial class Form_Tutores : Form
    {
        public int IdTutor = 0;
        string conexion = "Server=localhost;Database=guarderia;Uid=root;Pwd=root;";
        
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

        // Guardar 

        private void butGuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNom.Text) ||
        string.IsNullOrWhiteSpace(texApat.Text) ||
        string.IsNullOrWhiteSpace(textNUM.Text))
            {
                MessageBox.Show("Completa los campos obligatorios");
                return;
            }

            if (string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                MessageBox.Show("Selecciona una imagen");
                return;
            }

            string nombre = textNom.Text;
            string Apaterno = texApat.Text;
            string Amaterno = textAMate.Text;
            string NumTele = textNUM.Text;

            string extension = Path.GetExtension(rutaImagenSeleccionada);
            string nombreArchivo = Guid.NewGuid().ToString() + extension;
            string rutaGuardar = Path.Combine(CarpF, nombreArchivo);

            File.Copy(rutaImagenSeleccionada, rutaGuardar, true);

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query;

                if (IdTutor == 0)
                {
                    query = "INSERT INTO tutores (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, RutaImagen) VALUES (@nom,@ap,@am,@tel,@img)";
                }
                else
                {
                    query = "UPDATE tutores SET Nombre=@nom, ApellidoPaterno=@ap, ApellidoMaterno=@am, Telefono=@tel WHERE IdTutor=@id";
                }

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@ap", Apaterno);
                cmd.Parameters.AddWithValue("@am", Amaterno);
                cmd.Parameters.AddWithValue("@tel", NumTele);
                cmd.Parameters.AddWithValue("@img", rutaGuardar);

                if (IdTutor != 0)
                    cmd.Parameters.AddWithValue("@id", IdTutor);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Datos guardados correctamente");

            if (string.IsNullOrWhiteSpace(textNom.Text) ||
                string.IsNullOrWhiteSpace(texApat.Text) ||
                string.IsNullOrWhiteSpace(textNUM.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios");
                return;
            }

            textNom.Clear();
            texApat.Clear();
            textAMate.Clear();
            textNUM.Clear();
            picBoxImage.Image = null;
            rutaImagenSeleccionada = "";


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
                rutaImagenSeleccionada = openFile.FileName;
                using (FileStream fs = new FileStream(rutaImagenSeleccionada, FileMode.Open, FileAccess.Read))
                {
                    picBoxImage.Image = Image.FromStream(fs);
                }
            }

        }

        private void picBoxImage_Click(object sender, EventArgs e)
        {
            //vacio 
        }
    

    }
}
