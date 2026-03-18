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
                if (dataGridView1.CurrentRow != null)
                {
                    Form_Tutores frm = new Form_Tutores();

                    frm.IdTutor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTutor"].Value);

                    frm.textNom.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    frm.texApat.Text = dataGridView1.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                    frm.textAMate.Text = dataGridView1.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                    frm.textNUM.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();

                    frm.ShowDialog();

                    CargarDatos();
                }


            }
            //MessageBox.Show("Actualizado");
            //CargarDatos();
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

                if (fila.Cells["RutaImagen"].Value != null)
                {
                    string ruta = fila.Cells["RutaImagen"].Value.ToString();

                    if (File.Exists(ruta))
                    {
                        // Liberar imagen anterior (evita errores)
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
