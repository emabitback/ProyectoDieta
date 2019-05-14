using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrid
{
    public partial class MenuNutriologo : Form
    {
        public MenuNutriologo()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            /*
             * Cambia el color de la fuente cuando se despliega el menú 
             */
            pacientesToolStripMenuItem.ForeColor = Color.Gray;
        }

        private void pacientesToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            /*
             * Cambia el color de la fuente cuando se cierra el menú 
             */
            pacientesToolStripMenuItem.ForeColor = Color.White;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarPaciente1.BringToFront();
        }

        private void consultaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaIndividual1.BringToFront();
        }
    }
}
