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
using System.Data;



namespace ProyectoGuarderia
{
    public partial class Form_Padres : Form
    {
        public Form_Padres()
        {
            
            InitializeComponent();
        }

        string conexion = "server=localhost;database=guarderia;uid=root;pwd=root;";
        MySqlConnection conn = new MySqlConnection("server=localhost;database=guarderia;uid=root;pwd=root;");
        private void CargarPadres()
        {
            try
            {
                conn.Open();

                string query = @"SELECT 
                        IdPadre,
                        Nombre,
                        Telefono,
                        Direccion
                        FROM padres";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPadres.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPadres_Click(object sender, EventArgs e)
        {
            //No tiene funcionalidad ya pero si lo quito no funciona

        }

        private void pbPadres_Click_1(object sender, EventArgs e)
        {
          


        }

        private void btnAgregarPadre_Click(object sender, EventArgs e)
        {
            //// Oculta el menú y abre Form_Niños
            //// Al cerrar Form_Niños se vuelve a mostrar el menú.
            //this.Hide();
            //using (var formPadre = new Form_Padre())
            //{
            //    formPadre.ShowDialog();
            //}
            //this.Show();
        }

        private void Form_Padres_Load(object sender, EventArgs e)
        {
            CargarPadres();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"SELECT 
                        IdPadre,
                        Nombre,
                        Telefono,
                        Direccion
                        FROM padres
                        WHERE Nombre LIKE @nombre";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscarPadre.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPadres.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPadre_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            using (var formPadre = new Form_Padre())
            {
                formPadre.ShowDialog();
            }

            this.Show();

            CargarPadres(); // actualiza la lista
        }

        private void dgvPadres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPadre = Convert.ToInt32(dgvPadres.CurrentRow.Cells["IdPadre"].Value);

            this.Hide();

            Form_Padre formPadre = new Form_Padre(idPadre);
            formPadre.ShowDialog();

            this.Show();

            CargarPadres();
        }

        private void dgvPadres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvPadres.CurrentRow != null)
                {
                    int idPadre = Convert.ToInt32(
                        dgvPadres.CurrentRow.Cells["IdPadre"].Value
                    );

                    Form_Padre formPadre = new Form_Padre(idPadre);

                    formPadre.ShowDialog();

                    CargarPadres(); // refrescar lista
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
