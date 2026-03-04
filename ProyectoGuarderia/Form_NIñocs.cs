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



namespace ProyectoGuarderia
{
    public partial class Form_Niño : Form
    {
        string rutaImagen = "";

        public Form_Niño()
        {
            InitializeComponent();
        }

        private void Form_Niño_Load(object sender, EventArgs e)
        {
            // llenar ComboBox sexo
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.SelectedIndex = -1;

            // Fecha de registro automática
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // vacío
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // vacío
        }

        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {
            // opcional
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

        // SELECCIONAR FOTO
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Seleccionar foto";
            ofd.Filter = "Imagen (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = ofd.FileName;

                pictureBoxFoto.Image = Image.FromFile(rutaImagen);

                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // GUARDAR NIÑO
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaGuardar = "";

                // guardar imagen en carpeta del programa
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    string carpeta = Application.StartupPath + @"\Fotos\";

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    string extension = Path.GetExtension(rutaImagen);

                    string nombreArchivo = Guid.NewGuid().ToString() + extension;

                    rutaGuardar = carpeta + nombreArchivo;

                    File.Copy(rutaImagen, rutaGuardar, true);
                }

                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = @"INSERT INTO Nino
                                    (
                                        Nombre,
                                        Apaterno,
                                        Amaterno,
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
                                        @FechaNacimiento,
                                        @Sexo,
                                        @Foto,
                                        @FechaRegistro
                                    )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apaterno", txtApaterno.Text);
                    cmd.Parameters.AddWithValue("@Amaterno", txtAmaterno.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);
                    cmd.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@Foto", rutaGuardar);
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

        // LIMPIAR CAMPOS
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
    }
}