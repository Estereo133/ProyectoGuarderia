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

        private void btnTutores_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formTutores = new tutoresTablas())
            {
                formTutores.ShowDialog();
            }
            this.Show();
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            
            new Form_Busqueda().ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            // Oculta el menú y abre Form_Niños
            // Al cerrar Form_Niños se vuelve a mostrar el menú.
            this.Hide();
            using (var formPagos = new Form_Pagos())
            {
                formPagos.ShowDialog();
            }
            this.Show();
        }
        private void btnAyuda_MouseLeave(object sender, EventArgs e)
        {
            if (btnAyuda.BackColor == Color.Red)
            {
                btnAyuda.BackColor = Color.Cyan;
            }
        }

        private void btnAyuda_MouseEnter(object sender, EventArgs e)
        {
            if (btnAyuda.BackColor != Color.Red)
            {
                btnAyuda.BackColor = Color.Red;
            }
        }
        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            Emergencias_Num ventana = new Emergencias_Num();
            ventana.Show();
        }

        //end
    }
    }


