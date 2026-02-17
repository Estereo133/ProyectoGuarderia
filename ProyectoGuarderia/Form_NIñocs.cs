using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGuarderia
{
    public partial class Form_Niño : Form
    {
        public Form_Niño()
        {
            InitializeComponent();
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
    }
}
