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
using MySql.Data.MySqlClient;




namespace ProyectoGuarderia
{

    public partial class Form_Padre : Form
    {
        string rutaImagen = "";

        public Form_Padre()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // código o dejar vacío
        }

        private void pbPadre_DoubleClick(object sender, EventArgs e)
        {
            // código o dejar vacío
        }
        // CARGAR NIÑOS
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
                        reader["IdNino"].ToString() +
                        " - " +
                        reader["Nombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DOBLE CLICK PARA SUBIR FOTO
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Imagen|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = ofd.FileName;

                pictureBoxPadre.Image = Image.FromFile(rutaImagen);
            }
        }

        // GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNino.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un niño");
                    return;
                }

                string idNino =
                cmbNino.SelectedItem.ToString().Split('-')[0].Trim();

                string rutaGuardar = "";

                if (rutaImagen != "")
                {
                    string carpeta =
                    Application.StartupPath + @"\FotosPadres\";

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    string nombreArchivo =
                    Guid.NewGuid().ToString() + ".jpg";

                    rutaGuardar = carpeta + nombreArchivo;

                    File.Copy(rutaImagen, rutaGuardar, true);
                }

                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = @"INSERT INTO padres
                    (IdNino, Nombre, Telefono, Direccion, Imagen)
                    VALUES
                    (@IdNino, @Nombre, @Telefono, @Direccion, @Imagen)";

                    MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IdNino", idNino);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Imagen", rutaGuardar);
                    
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Padre guardado correctamente");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cmbNino.SelectedIndex = -1;

            pictureBoxPadre.Image = null;

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
        string rutaImagenPadre = "";

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagenPadre = ofd.FileName;
                pictureBoxPadre.Image = Image.FromFile(rutaImagenPadre);
            }
        }
    }
}