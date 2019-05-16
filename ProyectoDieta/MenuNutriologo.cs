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
    public partial class MenuNutriologo : MaterialSkin.Controls.MaterialForm
    {
        public MenuNutriologo()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(this.MenuNutriologo_Closing);
        }

        private void MenuNutriologo_Load(object sender, EventArgs e)
        {

        }
 
        private void MenuNutriologo_Closing(Object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();

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
            OpenForm(new form());
        }
    }
}
