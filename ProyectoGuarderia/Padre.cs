using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// 📸 CÁMARA
using Accord.Video;
using Accord.Video.DirectShow;

namespace ProyectoGuarderia
{
    public partial class Form_Padre : Form
    {
        int idPadre = 0;
        int idNinoSeleccionado = 0;

        string rutaImagen = "";

        // 📸 VARIABLES DE CÁMARA
        FilterInfoCollection dispositivos;
        VideoCaptureDevice camara;

        public Form_Padre()
        {
            InitializeComponent();
        }

        public Form_Padre(int id)
        {
            InitializeComponent();
            idPadre = id;
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
        // 📥 CARGAR PADRE
        // ============================
        private void CargarPadre()
        {
            using (MySqlConnection conn = Conexion.conectar())
            {
                conn.Open();

                string query = "SELECT * FROM padres WHERE IdPadre=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idPadre);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtTelefono.Text = reader["Telefono"].ToString();
                    txtDireccion.Text = reader["Direccion"].ToString();
                    txtocupacion.Text = reader["Ocupacion"].ToString();

                    idNinoSeleccionado = Convert.ToInt32(reader["IdNino"]);

                    string ruta = reader["Image"].ToString();

                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                        pictureBoxPadre.Image = Image.FromFile(ruta);
                    else
                        pictureBoxPadre.Image = Properties.Resources.usuario;
                }
            }
        }

        // ============================
        // 📋 LOAD
        // ============================
        private void Form_Padre_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = "SELECT IdNino, Nombre FROM nino";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbNino.Items.Clear();

                    while (reader.Read())
                    {
                        cmbNino.Items.Add(
                            reader["IdNino"].ToString() + " - " +
                            reader["Nombre"].ToString());
                    }
                }

                if (idPadre != 0)
                {
                    CargarPadre();

                    for (int i = 0; i < cmbNino.Items.Count; i++)
                    {
                        string item = cmbNino.Items[i].ToString();

                        if (item.StartsWith(idNinoSeleccionado.ToString() + " -"))
                        {
                            cmbNino.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ============================
        // 📸 FOTO (CÁMARA + ARCHIVO)
        // ============================
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Deseas tomar foto con la cámara?",
                "Foto",
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
                        Bitmap imagen = (Bitmap)ev.Frame.Clone();
                        pictureBoxPadre.Image = imagen;
                        pictureBoxPadre.SizeMode = PictureBoxSizeMode.StretchImage;
                    };

                    camara.Start();

                    MessageBox.Show("Cámara activada.\nPresiona OK para tomar la foto.");

                    if (pictureBoxPadre.Image == null)
                    {
                        MessageBox.Show("No se pudo capturar la imagen");
                        return;
                    }

                    string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosPadre";

                    if (!Directory.Exists(rutaBase))
                        Directory.CreateDirectory(rutaBase);

                    string identificador = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string rutaFinal = Path.Combine(rutaBase, $"Padre_{identificador}.jpg");

                    pictureBoxPadre.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagen = rutaFinal;

                    MessageBox.Show("Foto guardada correctamente ✅");

                    // 🔴 DETENER CÁMARA
                    if (camara != null && camara.IsRunning)
                    {
                        camara.SignalToStop();
                        camara.WaitForStop();
                    }
                }
                else
                {
                    MessageBox.Show("No se detectó cámara");
                }
            }

            // 🖼️ ARCHIVO
            else if (opcion == DialogResult.No)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagen|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPadre.Image = Image.FromFile(ofd.FileName);
                    pictureBoxPadre.SizeMode = PictureBoxSizeMode.StretchImage;

                    string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosPadre";

                    if (!Directory.Exists(rutaBase))
                        Directory.CreateDirectory(rutaBase);

                    string identificador = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string rutaFinal = Path.Combine(rutaBase, $"Padre_{identificador}.jpg");

                    pictureBoxPadre.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagen = rutaFinal;

                    MessageBox.Show("Imagen guardada correctamente ✅");
                }
            }
        }

        // ============================
        // 💾 GUARDAR
        // ============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNino.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un niño");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Nombre obligatorio");
                    return;
                }

                if (!SoloLetras(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no debe tener números");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Teléfono obligatorio");
                    return;
                }

                if (!SoloNumeros(txtTelefono.Text) || txtTelefono.Text.Length < 10)
                {
                    MessageBox.Show("Teléfono inválido");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Dirección obligatoria");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtocupacion.Text))
                {
                    MessageBox.Show("Ocupación obligatoria");
                    return;
                }

                if (string.IsNullOrEmpty(rutaImagen))
                {
                    MessageBox.Show("Debes agregar una foto");
                    return;
                }

                string idNino = cmbNino.SelectedItem.ToString().Split('-')[0].Trim();

                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query;

                    if (idPadre == 0)
                    {
                        query = @"INSERT INTO padres
                        (IdNino, Nombre, Telefono, Direccion, Image, Ocupacion)
                        VALUES
                        (@IdNino, @Nombre, @Telefono, @Direccion, @Image, @Ocupacion)";
                    }
                    else
                    {
                        query = @"UPDATE padres SET
                        IdNino=@IdNino,
                        Nombre=@Nombre,
                        Telefono=@Telefono,
                        Direccion=@Direccion,
                        Image=@Image,
                        Ocupacion=@Ocupacion
                        WHERE IdPadre=@IdPadre";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IdNino", idNino);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Image", rutaImagen);
                    cmd.Parameters.AddWithValue("@Ocupacion", txtocupacion.Text);

                    if (idPadre != 0)
                        cmd.Parameters.AddWithValue("@IdPadre", idPadre);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Padre guardado correctamente ✅");
                Limpiar();
                this.Close();
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
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtocupacion.Clear();

            cmbNino.SelectedIndex = -1;
            pictureBoxPadre.Image = null;

            rutaImagen = "";
        }

        // ============================
        // 🔴 EVENTOS
        // ============================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Padre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }
    }
}
