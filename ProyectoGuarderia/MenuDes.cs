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
        }

        private void paneMenu_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void MenuDes_Load(object sender, EventArgs e)
        {
            //ocultamos tiodfdo los paneles  de sub menu al iniciar la app
           
            OcultarSubMenus();
        }
        private void OcultarSubMenus()
        {
            SubPanel_Niños.Visible = false;
            SubPanel_Padres.Visible = false;
            SubPanel_Tutores.Visible = false;
        }
    }
}
