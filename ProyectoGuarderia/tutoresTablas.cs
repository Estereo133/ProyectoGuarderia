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

        string conexion = "Server=localhost;Database=guarderia;Uid=root;Pwd=root;"; public tutoresTablas()
        {
            InitializeComponent();
        }

        private void tutoresTablas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void CargarDatos()
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tutores", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Tutores frm = new Form_Tutores();
            frm.ShowDialog();

            CargarDatos(); // vuelve a cargar datos despues de de guardar 
        }
        // eliminar tutor
        private void buttEleminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow !=null) {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTutor"].Value);

                DialogResult r = MessageBox.Show("¿Eliminar este tutor?", "Confirmar", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(conexion))
                    {
                        con.Open();
                        string query = "DELETE FROM tutores WHERE IdTutor=@id";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(" se a eliminado al tutor");
                    CargarDatos();
                }

            }

        }

        private void butedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTutor"].Value);

                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();
                    string query = "UPDATE tutores SET Nombre=@nom, ApellidoPaterno=@ap, ApellidoMaterno=@am, Telefono=@tel WHERE IdTutor=@id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", textNom.Text);
                    cmd.Parameters.AddWithValue("@ap", texApat.Text);
                    cmd.Parameters.AddWithValue("@am", textAMate.Text);
                    cmd.Parameters.AddWithValue("@tel", textNUM.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Actualizado");
                CargarDatos();
            }
        }
        
        private void texbuscar_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query = "SELECT * FROM tutores WHERE Nombre LIKE @busqueda";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + texbuscar.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridView1.Rows[e.RowIndex];
                // llenar los espacios ç

                textNom.Text = fila.Cells["Nombre"].Value?.ToString();
                texApat.Text = fila.Cells["ApellidoPaterno"].Value?.ToString();
                textAMate.Text = fila.Cells["ApellidoMaterno"].Value?.ToString();
                textNUM.Text = fila.Cells["Telefono"].Value?.ToString();


                // muestra las imagebes 
                if (fila.Cells["RutaImagen"].Value != null)
                {
                    string ruta = fila.Cells["RutaImagen"].Value.ToString();

                    if (File.Exists(ruta))
                        pictureBox1.Image = null;
                    using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                    }

                    textNom.Clear();
                    texApat.Clear();
                    textAMate.Clear();
                    textNUM.Clear();
                    pictureBox1.Image = null;
                }

            }
        }
    }

}
