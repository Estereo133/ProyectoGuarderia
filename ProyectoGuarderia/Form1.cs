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
    //Para provar el guardar los cambios en GitHub
    //Hola Prueba para ver asi guardo cambios dss
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void lbl_Menu_Click(object sender, EventArgs e)
        {

        }

        private void labelDivicion_Click(object sender, EventArgs e)
        {

        }

        private void btnNiños_Click(object sender, EventArgs e)
        {
            // Oculta el menú y abre Form_Niños
            // Al cerrar Form_Niños se vuelve a mostrar el menú.
            this.Hide();
            using (var formNiños = new Form_Niños())
            {
                formNiños.ShowDialog();
            }
            this.Show();
        }

        private void btnPadres_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formPadres = new Form_Padres())


            {
                formPadres.ShowDialog();
            }
            this.Show();
        }
        /
    }
}