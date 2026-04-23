using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

using Accord.Video;
using Accord.Video.DirectShow;

namespace ProyectoGuarderia
{
    public partial class Form_Niño : Form
    {
        string rutaImagen = "";

        FilterInfoCollection dispositivos;
        VideoCaptureDevice camara;

        public Form_Niño()
        {
            InitializeComponent();
        }

        private void Form_Niño_Load(object sender, EventArgs e)
        {
            cmbSexo.SelectedIndex = -1;
            dtpFechaRegistro.Value = DateTime.Now;

            // 🔥 ACTIVAR CURP AUTOMÁTICA
            txtNombre.TextChanged += (s, ev) => ActualizarCURP();
            txtApaterno.TextChanged += (s, ev) => ActualizarCURP();
            txtAmaterno.TextChanged += (s, ev) => ActualizarCURP();
            dtpFechaNacimiento.ValueChanged += (s, ev) => ActualizarCURP();
            cmbSexo.SelectedIndexChanged += (s, ev) => ActualizarCURP();
        }

        // ============================
        // 📸 FOTO
        // ============================
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Deseas usar la cámara?",
                "Foto",
                MessageBoxButtons.YesNoCancel
            );

            if (opcion == DialogResult.Yes)
            {
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (dispositivos.Count == 0)
                {
                    MessageBox.Show("No hay cámara");
                    return;
                }

                camara = new VideoCaptureDevice(dispositivos[0].MonikerString);

                camara.NewFrame += (s, ev) =>
                {
                    pictureBoxFoto.Image = (System.Drawing.Bitmap)ev.Frame.Clone();
                };

                camara.Start();

                MessageBox.Show("Presiona OK para capturar");

                if (pictureBoxFoto.Image == null)
                {
                    MessageBox.Show("Error al capturar");
                    return;
                }

                string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosAlumno";

                if (!Directory.Exists(rutaBase))
                    Directory.CreateDirectory(rutaBase);

                string ruta = Path.Combine(rutaBase, "Alumno_" + DateTime.Now.Ticks + ".jpg");

                pictureBoxFoto.Image.Save(ruta);
                rutaImagen = ruta;

                if (camara.IsRunning)
                {
                    camara.SignalToStop();
                    camara.WaitForStop();
                }

                MessageBox.Show("Foto guardada");
            }
            else if (opcion == DialogResult.No)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagen|*.jpg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoto.Image = System.Drawing.Image.FromFile(ofd.FileName);

                    string rutaBase = @"C:\Users\rosar\OneDrive\Desktop\PG\ProyectoGuarderia\bin\Debug\FotosAlumno";

                    if (!Directory.Exists(rutaBase))
                        Directory.CreateDirectory(rutaBase);

                    string ruta = Path.Combine(rutaBase, "Alumno_" + DateTime.Now.Ticks + ".jpg");

                    pictureBoxFoto.Image.Save(ruta);
                    rutaImagen = ruta;
                }
            }
        }

        // ============================
        // 🔥 GENERAR CURP
        // ============================
        private string GenerarCURP()
        {
            if (txtNombre.Text == "" || txtApaterno.Text == "" || txtAmaterno.Text == "")
                return "";

            string nom = txtNombre.Text.ToUpper();
            string ap = txtApaterno.Text.ToUpper();
            string am = txtAmaterno.Text.ToUpper();

            char v = 'X';
            for (int i = 1; i < ap.Length; i++)
            {
                if ("AEIOU".Contains(ap[i]))
                {
                    v = ap[i];
                    break;
                }
            }

            string fecha = dtpFechaNacimiento.Value.ToString("yyMMdd");
            string sexo = cmbSexo.Text == "Masculino" ? "H" : "M";

            return $"{ap[0]}{v}{am[0]}{nom[0]}{fecha}{sexo}";
        }

        private void ActualizarCURP()
        {
            txtCurp.Text = GenerarCURP();
        }

        // ============================
        // 💾 GUARDAR
        // ============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApaterno.Text == "" || txtAmaterno.Text == "")
                {
                    MessageBox.Show("Completa los datos");
                    return;
                }

                if (cmbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona sexo");
                    return;
                }

                if (rutaImagen == "")
                {
                    MessageBox.Show("Agrega foto");
                    return;
                }

                using (MySqlConnection conn = Conexion.conectar())
                {
                    conn.Open();

                    string q = @"INSERT INTO Nino
                    (Nombre,Apaterno,Amaterno,CURP,FechaNacimiento,Sexo,Foto,FechaRegistro)
                    VALUES
                    (@n,@ap,@am,@c,@fn,@s,@f,@fr)";

                    MySqlCommand cmd = new MySqlCommand(q, conn);

                    cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ap", txtApaterno.Text);
                    cmd.Parameters.AddWithValue("@am", txtAmaterno.Text);
                    cmd.Parameters.AddWithValue("@c", txtCurp.Text);
                    cmd.Parameters.AddWithValue("@fn", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@s", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@f", rutaImagen);
                    cmd.Parameters.AddWithValue("@fr", dtpFechaRegistro.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Guardado correctamente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ============================
        // 🔴 EVENTOS QUE FALTABAN
        // ============================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgTutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Tutores().ShowDialog();
            this.Show();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            if (txtCurp.Text.Length > 18)
            {
                txtCurp.Text = txtCurp.Text.Substring(0, 18);
                txtCurp.SelectionStart = txtCurp.Text.Length;
            }
        }

        private void btnAgregarPadre_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Padre().ShowDialog();
            this.Show();
        }

        private void Form_Niño_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApaterno.Clear();
            txtAmaterno.Clear();
            txtCurp.Clear();
            pictureBoxFoto.Image = null;
            cmbSexo.SelectedIndex = -1;
        }
    }
}