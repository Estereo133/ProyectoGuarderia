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



namespace ProyectoGuarderia
{
    public partial class Form_Padres : Form
    {
        public Form_Padres()
        {
            InitializeComponent();
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
            // Oculta el menú y abre Form_Niños
            // Al cerrar Form_Niños se vuelve a mostrar el menú.
            this.Hide();
            using (var formPadre = new Form_Padre())
            {
                formPadre.ShowDialog();
            }
            this.Show();
        }
    }
}
