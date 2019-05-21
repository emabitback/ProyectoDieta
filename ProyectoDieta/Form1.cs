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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            if (txt_nombreUsuario.Text == "admin" && txt_contrasena.Text == "admin")
            {
                MenuNutriologo mn = new MenuNutriologo();
                mn.Show();
            }


            if (txt_nombreUsuario.Text == "user" && txt_contrasena.Text == "user")
            {
                MenuPaciente mp = new MenuPaciente();
                mp.Show();
            }

            txt_nombreUsuario.Clear();
            txt_contrasena.Clear();

           
        }
    }
}
