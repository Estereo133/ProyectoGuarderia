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
    public partial class Form_Niños : Form
    {
        public Form_Niños()
        {
            InitializeComponent();
            // no es nesesario ya que al hacer doble click en el botón en el
            // diseñador de Visual Studio, se genera automáticamente el evento
            // Click y su manejador btnSalir_Click
            //this.btnSalir.Click += this.btnSalir_Click;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra este formulario y el FormClosed en el menú se encargará de mostrarlo otra vez
            this.Close();
        }
    }
}