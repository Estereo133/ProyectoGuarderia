using System;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// 📸 CÁMARA
using Accord.Video;
using Accord.Video.DirectShow;

namespace ProyectoGuarderia
{
    public partial class Form_Tutores : Form
    {
        public int IdTutor = 0;
        string conexion = "Server=localhost;Database=guarderia;Uid=root;Pwd=root;";

        private string CarpF;
        private string rutaImagenSeleccionada = "";

        // 📸 VARIABLES CÁMARA
        FilterInfoCollection dispositivos;
        VideoCaptureDevice camara;

        public Form_Tutores()
        {
            InitializeComponent();

            // 📂 CARPETA CORRECTA
            CarpF = Path.Combine(Application.StartupPath, "FotosTutor");

            if (!Directory.Exists(CarpF))
                Directory.CreateDirectory(CarpF);
        }

        // ============================
        // 🔥 VALIDACIONES
        // ============================
        private bool SoloLetras(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool SoloNumeros(string texto)
        {
            return texto.All(char.IsDigit);
        }

        // ============================
        // 📸 FOTO (CÁMARA + ARCHIVO)
        // ============================
        private void butImage_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Deseas usar la cámara?",
                "Imagen Tutor",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // 📸 CÁMARA
            if (opcion == DialogResult.Yes)
            {
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (dispositivos.Count > 0)
                {
                    camara = new VideoCaptureDevice(dispositivos[0].MonikerString);

                    camara.NewFrame += (s, ev) =>
                    {
                        Bitmap img = (Bitmap)ev.Frame.Clone();
                        picBoxImage.Image = img;
                        picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    };

                    camara.Start();

                    MessageBox.Show("Cámara activada.\nPresiona OK para capturar.");

                    if (picBoxImage.Image == null)
                    {
                        MessageBox.Show("No se pudo capturar imagen");
                        return;
                    }

                    string nombreArchivo = "Tutor_" + DateTime.Now.Ticks + ".jpg";
                    string rutaFinal = Path.Combine(CarpF, nombreArchivo);

                    picBoxImage.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagenSeleccionada = rutaFinal;

                    MessageBox.Show("Foto guardada correctamente ✅");

                    if (camara != null && camara.IsRunning)
                    {
                        camara.SignalToStop();
                        camara.WaitForStop();
                    }
                }
                else
                {
                    MessageBox.Show("No hay cámara disponible");
                }
            }

            // 🖼️ ARCHIVO
            else if (opcion == DialogResult.No)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = openFile.FileName;

                    using (FileStream fs = new FileStream(rutaImagenSeleccionada, FileMode.Open, FileAccess.Read))
                    {
                        picBoxImage.Image = Image.FromStream(fs);
                    }

                    string nombreArchivo = "Tutor_" + DateTime.Now.Ticks + ".jpg";
                    string rutaFinal = Path.Combine(CarpF, nombreArchivo);

                    picBoxImage.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagenSeleccionada = rutaFinal;

                    MessageBox.Show("Imagen guardada correctamente ✅");
                }
            }
        }

        // ============================
        // 💾 GUARDAR
        // ============================
        private void butGuar_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔴 VALIDACIONES
                if (string.IsNullOrWhiteSpace(textNom.Text))
                {
                    MessageBox.Show("Nombre obligatorio");
                    return;
                }

                if (!SoloLetras(textNom.Text))
                {
                    MessageBox.Show("El nombre no debe contener números");
                    return;
                }

                if (string.IsNullOrWhiteSpace(texApat.Text))
                {
                    MessageBox.Show("Apellido paterno obligatorio");
                    return;
                }

                if (!SoloLetras(texApat.Text))
                {
                    MessageBox.Show("Apellido paterno inválido");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textNUM.Text))
                {
                    MessageBox.Show("Teléfono obligatorio");
                    return;
                }

                if (!SoloNumeros(textNUM.Text) || textNUM.Text.Length < 10)
                {
                    MessageBox.Show("Teléfono inválido (mínimo 10 dígitos)");
                    return;
                }

                if (string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                    MessageBox.Show("Debes agregar una imagen");
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    string query;

                    if (IdTutor == 0)
                    {
                        query = @"INSERT INTO tutores 
                        (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, RutaImagen) 
                        VALUES (@nom,@ap,@am,@tel,@img)";
                    }
                    else
                    {
                        query = @"UPDATE tutores SET 
                        Nombre=@nom, 
                        ApellidoPaterno=@ap, 
                        ApellidoMaterno=@am, 
                        Telefono=@tel,
                        RutaImagen=@img
                        WHERE IdTutor=@id";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nom", textNom.Text);
                    cmd.Parameters.AddWithValue("@ap", texApat.Text);
                    cmd.Parameters.AddWithValue("@am", textAMate.Text);
                    cmd.Parameters.AddWithValue("@tel", textNUM.Text);
                    cmd.Parameters.AddWithValue("@img", rutaImagenSeleccionada);

                    if (IdTutor != 0)
                        cmd.Parameters.AddWithValue("@id", IdTutor);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tutor guardado correctamente ✅");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ============================
        // 🧹 LIMPIAR
        // ============================
        private void Limpiar()
        {
            textNom.Clear();
            texApat.Clear();
            textAMate.Clear();
            textNUM.Clear();

            picBoxImage.Image = null;
            rutaImagenSeleccionada = "";
        }

        // ============================
        // 🔴 EVENTOS
        // ============================
        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Tutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }

        private void texApat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}