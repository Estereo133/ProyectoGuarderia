using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGuarderia
{
    public partial class MenuDes : Form
    {
        public MenuDes()
        {
            InitializeComponent();
            OcultarSubMenus();

        }

        private void paneMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuDes_Load(object sender, EventArgs e)
        {
            //ocultamos tiodfdo los paneles  de sub menu al iniciar la app

            
        }
        private void OcultarSubMenus()
        {
            SubPanel_Niños.Visible = false;
            SubPanel_Padres.Visible = false;
            SubPanel_Tutores.Visible = false;
        }
        //mostrar sub menu
        private void hideSubmenu() {
            if (SubPanel_Niños.Visible == true)
                SubPanel_Niños.Visible = false;
            if (SubPanel_Padres.Visible == true)
                SubPanel_Padres.Visible = false;
            if (SubPanel_Tutores.Visible == true)
                SubPanel_Tutores.Visible = false;
        }
        private void showsubmenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else { 
                subMenu.Visible = false;
            }
            
        }
        //NIÑOS
        private void button_niños_Click(object sender, EventArgs e)
        {
            showsubmenu(SubPanel_Niños);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }
        //PADRES
        private void butto_padres_Click(object sender, EventArgs e)
        {
            showsubmenu(SubPanel_Padres);
        }

        private void button_SUBpadres1_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button_SUBpadres2_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }
        //TUTORES
        private void button5_Click(object sender, EventArgs e)
        {
            showsubmenu(SubPanel_Tutores);
        }

        private void button_SUBtutores1_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button_SUBtutores2_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }

        private void button_SUBtutores3_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }
        //pago
        private void button15_Click(object sender, EventArgs e)
        {
            //aqui ponen lo que vallan a poner

            hideSubmenu();
        }
    }
}
