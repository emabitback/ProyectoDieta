<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
﻿using System;
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
    public partial class MenuPaciente  : MaterialSkin.Controls.MaterialForm
    {
        string correo;
        public MenuPaciente(string correo)
        {
            this.correo = correo;
            InitializeComponent();
        }

        private void OpenForm(object formHijo)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();

        }

        private void MenuPaciente_Load(object sender, EventArgs e)
        {
            ImagenFondo.Visible = true;
            this.Text = "";
        }

        private void miPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagenFondo.Visible = false;
            OpenForm(new MiPlan(correo));
            
        }
    }
}
<<<<<<< HEAD
=======
=======
﻿using System;
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
    public partial class MenuPaciente  : MaterialSkin.Controls.MaterialForm
    {
        public MenuPaciente()
        {
            InitializeComponent();
        }

        private void OpenForm(object formHijo)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();

        }

        private void MenuPaciente_Load(object sender, EventArgs e)
        {
            ImagenFondo.Visible = true;
        }

        private void miPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagenFondo.Visible = false;
            OpenForm(new MiPlan());
            
        }
    }
}
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
