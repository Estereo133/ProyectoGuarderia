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
    public partial class Inf_comNIno : Form
    {
        public string nombre;
        public string apaterno;
        public string amaterno;
        public string fecha;
        public string sexo;
        public string foto;

        public Inf_comNIno()
        {
            InitializeComponent();
        }

        private void Inf_comNIno_Load(object sender, EventArgs e)
        {
            labNom.Text = nombre;
            labeApa.Text = apaterno;
            labAma.Text = amaterno;
            lafecha.Text = fecha;
            labeGenero.Text = sexo;

            if (File.Exists(foto))
            {
                pictureBox1.Image = Image.FromFile(foto);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void labAma_Click(object sender, EventArgs e)
        {

        }
    }
}
