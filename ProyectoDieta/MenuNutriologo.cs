using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDieta
{
    public partial class MenuNutriologo : MaterialSkin.Controls.MaterialForm
    {
        public MenuNutriologo()
        {
            InitializeComponent();
        }

        private void MenuNutriologo_Load(object sender, EventArgs e)
        {

        }
        private void OpenForm(object formHijo){
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form fh=formHijo as Form;
            fh.TopLevel =false;
            fh.Dock=DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag=fh;
            fh.Show();

        }

        private void perrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new AltaPaciente());
        }

        private void gatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Alimentos());
        }
    }
}
