using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

// ✅ LIBRERÍAS CORRECTAS
using Accord.Video;
using Accord.Video.DirectShow;

namespace ProyectoGuarderia
{
    public partial class Form_Niño : Form
    {
        string rutaImagen = "";

        // 📸 VARIABLES DE CÁMARA
        FilterInfoCollection dispositivos;
        VideoCaptureDevice camara;

        public Form_Niño()
        {
            InitializeComponent();
        }

        private void Form_Niño_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.SelectedIndex = -1;

            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void btnAgregarPadre_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var formPadre = new Form_Padre())
            {
                formPadre.ShowDialog();
            }

            this.Show();
        }

        // ============================
        // 📸 SELECCIONAR / TOMAR FOTO
        // ============================
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Deseas tomar una foto con la cámara?",
                "Seleccionar opción",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // 📸 USAR CÁMARA
            if (opcion == DialogResult.Yes)
            {
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (dispositivos.Count > 0)
                {
                    camara = new VideoCaptureDevice(dispositivos[0].MonikerString);

                    camara.NewFrame += new NewFrameEventHandler((s, ev) =>
                    {
                        Bitmap imagen = (Bitmap)ev.Frame.Clone();
                        pictureBoxFoto.Image = imagen;
                        pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    });

                    camara.Start();

                    MessageBox.Show("Cámara activada.\nPresiona OK para tomar la foto.");

                    if (pictureBoxFoto.Image == null)
                    {
                        MessageBox.Show("No se pudo capturar la imagen");
                        return;
                    }

                    string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosAlumno";

                    if (!Directory.Exists(rutaBase))
                        Directory.CreateDirectory(rutaBase);

                    string identificador = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string rutaFinal = Path.Combine(rutaBase, $"Alumno_{identificador}.jpg");

                    pictureBoxFoto.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagen = rutaFinal;

                    MessageBox.Show("Foto guardada correctamente ✅");

                    // Detener cámara
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

            // 🖼️ SELECCIONAR ARCHIVO
            else if (opcion == DialogResult.No)
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Seleccionar foto";
                ofd.Filter = "Imagen (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoto.Image = Image.FromFile(ofd.FileName);
                    pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosAlumno";

                    if (!Directory.Exists(rutaBase))
                        Directory.CreateDirectory(rutaBase);

                    string identificador = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string rutaFinal = Path.Combine(rutaBase, $"Alumno_{identificador}.jpg");

                    pictureBoxFoto.Image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Jpeg);

                    rutaImagen = rutaFinal;

                    MessageBox.Show("Imagen guardada correctamente ✅");
                }
            }
        }

        // ============================
        // 💾 GUARDAR NIÑO
        // ============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = @"INSERT INTO Nino
                    (
                        Nombre,
                        Apaterno,
                        Amaterno,
                        CURP,
                        FechaNacimiento,
                        Sexo,
                        Foto,
                        FechaRegistro
                    )
                    VALUES
                    (
                        @Nombre,
                        @Apaterno,
                        @Amaterno,
                        @CURP,
                        @FechaNacimiento,
                        @Sexo,
                        @Foto,
                        @FechaRegistro
                    )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apaterno", txtApaterno.Text);
                    cmd.Parameters.AddWithValue("@Amaterno", txtAmaterno.Text);
                    cmd.Parameters.AddWithValue("@CURP", txtCurp.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);
                    cmd.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@Foto", rutaImagen);
                    cmd.Parameters.AddWithValue("@FechaRegistro", dtpFechaRegistro.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Niño registrado correctamente ✅");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApaterno.Clear();
            txtAmaterno.Clear();

            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaRegistro.Value = DateTime.Now;

            cmbSexo.SelectedIndex = -1;

            pictureBoxFoto.Image = null;
            rutaImagen = "";
        }

        private void btnAgTutor_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var formTutor = new Form_Tutores())
            {
                formTutor.ShowDialog();
            }

            this.Show();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            if (txtCurp.Text.Length > 18)
            {
                MessageBox.Show("El CURP no puede tener más de 18 caracteres.");
                txtCurp.Text = txtCurp.Text.Substring(0, 18);
                txtCurp.SelectionStart = txtCurp.Text.Length;
            }
        }

        // 🔴 Cerrar cámara al cerrar formulario
        private void Form_Niño_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }
    }
}