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
    public partial class Form_Tutores : Form
    {
        public Form_Tutores()
        {
            InitializeComponent();
        }

        private void Form_Tutores_Load(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuPruebas.Height += 70;
                if (MenuPruebas.Height >= 154)
                {
                    menuTimer.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                MenuPruebas.Height -= 70;
                if (MenuPruebas.Height <=44 ) {
                    menuTimer.Stop();
                    menuExpand = false;
                
                }
            }

        }

        private void MenuTutor_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        
    }
}
