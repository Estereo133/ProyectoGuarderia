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
    public partial class Form_Niños : Form
    {
        public Form_Niños()
        {
            InitializeComponent();
        }

        // ✅ MÉTODO PARA CARGAR LOS NIÑOS
        private void CargarNinos()
        {
            try
            {
                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = @"SELECT 
                                    IdNino,
                                    Nombre,
                                    Apaterno,
                                    Amaterno,
                                    FechaNacimiento,
                                    Sexo,
                                    Foto,
                                    FechaRegistro
                                    FROM nino";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvNinos.DataSource = dt;

                    // Ocultar la columna Foto (ruta)
                    if (dgvNinos.Columns.Contains("Foto"))
                        dgvNinos.Columns["Foto"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar niños: " + ex.Message);
            }
        }

        // ✅ AL ABRIR FORMULARIO
        private void Form_Niños_Load(object sender, EventArgs e)
        {
            CargarNinos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarNiño_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var formNiño = new Form_Niño())
            {
                formNiño.ShowDialog();
            }

            this.Show();

            // refrescar lista
            CargarNinos();
        }

        // ✅ MOSTRAR FOTO AL SELECCIONAR
        private void dgvNinos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvNinos.CurrentRow != null &&
                    dgvNinos.CurrentRow.Cells["Foto"].Value != null)
                {
                    string ruta = dgvNinos.CurrentRow.Cells["Foto"].Value.ToString();

                    if (File.Exists(ruta))
                    {
                        pictureBoxFoto.Image = Image.FromFile(ruta);
                    }
                    else
                    {
                        pictureBoxFoto.Image = null;
                    }
                }
            }
            catch
            {
                pictureBoxFoto.Image = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}