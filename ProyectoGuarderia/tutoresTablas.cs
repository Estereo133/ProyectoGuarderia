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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoGuarderia
{
    public partial class tutoresTablas : Form

    {
        string conexion = "Server=localhost;Database=guarderia;Uid=root;Pwd=root;";

        public tutoresTablas()
        {
            InitializeComponent();
        }

        private void tutoresTablas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            // Ajustar imagen al PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // CARGAR DATOS
        private void CargarDatos()
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                MySqlDataAdapter da =
                new MySqlDataAdapter("SELECT * FROM tutores", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // OCULTAR COLUMNA DE RUTA IMAGEN
                if (dataGridView1.Columns["RutaImagen"] != null)
                {
                    dataGridView1.Columns["RutaImagen"].Visible = false;
                }

                // AJUSTES VISUALES
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;
            }
        }

        // BOTON AGREGAR
        private void button2_Click(object sender, EventArgs e)
        {
            Form_Tutores frm = new Form_Tutores();

            frm.ShowDialog();

            // RECARGAR DATOS
            CargarDatos();
        }

        // ELIMINAR TUTOR
        private void buttEleminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["IdTutor"].Value);

                DialogResult r = MessageBox.Show(
                    "¿Eliminar este tutor?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    using (MySqlConnection con =
                    new MySqlConnection(conexion))
                    {
                        con.Open();

                        string query =
                        "DELETE FROM tutores WHERE IdTutor=@id";

                        MySqlCommand cmd =
                        new MySqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Se ha eliminado al tutor",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDatos();

                    pictureBox1.Image = null;
                }
            }
        }

        // EDITAR
        private void butedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Form_Tutores frm = new Form_Tutores();

                frm.IdTutor = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["IdTutor"].Value);

                frm.textNom.Text =
                dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();

                frm.texApat.Text =
                dataGridView1.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();

                frm.textAMate.Text =
                dataGridView1.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();

                frm.textNUM.Text =
                dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();

                // ENVIAR RUTA IMAGEN
                if (dataGridView1.CurrentRow.Cells["RutaImagen"].Value != null)
                {
                   // frm.RutaImagen =
                    dataGridView1.CurrentRow.Cells["RutaImagen"].Value.ToString();
                }

                frm.ShowDialog();

                CargarDatos();
            }
        }

        // BUSCAR
        private void texbuscar_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query =
                "SELECT * FROM tutores WHERE Nombre LIKE @busqueda";

                MySqlDataAdapter da =
                new MySqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@busqueda",
                    "%" + texbuscar.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // OCULTAR COLUMNA RUTA
                if (dataGridView1.Columns["RutaImagen"] != null)
                {
                    dataGridView1.Columns["RutaImagen"].Visible = false;
                }
            }
        }

        // MOSTRAR IMAGEN AL SELECCIONAR FILA
        private void dataGridView1_CellClick(object sender,
        DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                dataGridView1.Rows[e.RowIndex];

                if (fila.Cells["RutaImagen"].Value != DBNull.Value)
                {
                    string ruta =
                    fila.Cells["RutaImagen"].Value.ToString();

                    if (File.Exists(ruta))
                    {
                        // LIBERAR IMAGEN ANTERIOR
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        // CARGAR IMAGEN SIN BLOQUEAR ARCHIVO
                        using (Bitmap bmpTemp = new Bitmap(ruta))
                        {
                            pictureBox1.Image = new Bitmap(bmpTemp);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;

                        MessageBox.Show(
                            "La imagen no existe en la ruta guardada.");
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        // BOTON SALIR
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}