using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;




namespace ProyectoGuarderia
{
    public partial class Form_Busqueda : Form
    {
        public Form_Busqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string query = @"
SELECT 
n.IdNino,
n.Nombre,
n.Apaterno,
n.Amaterno,
n.FechaNacimiento,
n.Sexo,
n.Foto,
n.FechaRegistro,

p.Nombre AS Padre,
p.Telefono AS TelefonoPadre,
p.Direccion,
p.Image AS ImagenPadre,

t.Nombre AS Tutor,
t.Telefono AS TelefonoTutor,

pa.Monto,
pa.FechaPago

FROM nino n

LEFT JOIN padres p ON n.IdNino = p.IdNino
LEFT JOIN tutores t ON n.IdNino = t.IdNino
LEFT JOIN pagos pa ON n.IdNino = pa.IdNino

WHERE
n.IdNino LIKE @buscar
OR n.Nombre LIKE @buscar
OR n.Apaterno LIKE @buscar
";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@buscar", "%" + txtBuscar.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Crear nueva tabla vertical
                        DataTable dtVertical = new DataTable();
                        dtVertical.Columns.Add("Campo");
                        dtVertical.Columns.Add("Valor");

                        DataRow fila = dt.Rows[0]; // Tomamos solo el primer resultado

                        foreach (DataColumn col in dt.Columns)
                        {
                            // No mostrar las columnas de imagen
                            if (col.ColumnName != "Foto" &&
                                col.ColumnName != "ImagenPadre")
                            {
                                dtVertical.Rows.Add(
                                    col.ColumnName,
                                    fila[col.ColumnName]?.ToString()
                                );
                            }
                        }

                        dgvResultado.DataSource = dtVertical;

                        // 🔹 MOSTRAR IMÁGENES
                        string rutaNino = fila["Foto"]?.ToString();
                        if (!string.IsNullOrEmpty(rutaNino) && File.Exists(rutaNino))
                            pictureBoxFoto.Image = Image.FromFile(rutaNino);
                        else
                            pictureBoxFoto.Image = null;

                        string rutaPadre = fila["ImagenPadre"]?.ToString();
                        if (!string.IsNullOrEmpty(rutaPadre) && File.Exists(rutaPadre))
                            pictureBoxPadre.Image = Image.FromFile(rutaPadre);
                        else
                            pictureBoxPadre.Image = null;
                    }
                    else
                    {
                        dgvResultado.DataSource = null;
                        pictureBoxFoto.Image = null;
                        pictureBoxPadre.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvResultado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvResultado.CurrentRow != null)
                {
                    var valor = dgvResultado.CurrentRow.Cells["Foto"].Value;

                    if (valor != null)
                    {
                        string ruta = valor.ToString();

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
            }
            catch
            {
                pictureBoxFoto.Image = null;
            }
        }

        private void Form_Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void dgvResultado_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvResultado.CurrentRow != null)
                {
                    // FOTO DEL NIÑO
                    if (dgvResultado.Columns.Contains("Foto"))
                    {
                        string ruta =
                        dgvResultado.CurrentRow.Cells["Foto"].Value?.ToString();

                        if (!string.IsNullOrEmpty(ruta) &&
                            File.Exists(ruta))
                        {
                            pictureBoxFoto.Image =
                            Image.FromFile(ruta);
                        }
                        else
                        {
                            pictureBoxFoto.Image = null;
                        }
                    }

                    // FOTO DEL PADRE
                    if (dgvResultado.Columns.Contains("ImagenPadre"))
                    {
                        string rutaPadre =
                        dgvResultado.CurrentRow.Cells["ImagenPadre"].Value?.ToString();

                        if (!string.IsNullOrEmpty(rutaPadre) &&
                            File.Exists(rutaPadre))
                        {
                            pictureBoxPadre.Image =
                            Image.FromFile(rutaPadre);
                        }
                        else
                        {
                            pictureBoxPadre.Image = null;
                        }
                    }
                }
            }
            catch
            {
                pictureBoxFoto.Image = null;
                pictureBoxPadre.Image = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}