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
using MySql.Data.MySqlClient;
namespace ProyectoDieta
{
    public partial class MiPlan : Form
    {
<<<<<<< HEAD
        static string cadena_conexion = DatosConexion.cadena;         
=======
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629

        string correo;
        public MiPlan(string correo)
        {
            this.correo = correo;
            InitializeComponent();
        }

        private void MiPlan_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT * FROM dieta WHERE correo = ?correo", conexion);
            comd.Parameters.AddWithValue("?correo", correo);
            List_Lunes.Items.Clear();
            List_Martes.Items.Clear();
            List_Miercoles.Items.Clear();
            List_Jueves.Items.Clear();
            List_Viernes.Items.Clear();
            List_Sabado.Items.Clear();       

            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                    {
                        if (lector[1].ToString().Equals("Lunes"))
                        {
                            List_Lunes.Items.Add(lector[2]);                        
                        }
                        if (lector[1].ToString().Equals("Martes"))
                        {
                            List_Martes.Items.Add(lector[2]); 
                        }
                        if (lector[1].ToString().Equals("Miércoles"))
                        {
                            List_Miercoles.Items.Add(lector[2]); 
                        }
                        if (lector[1].ToString().Equals("Jueves"))
                        {
                            List_Jueves.Items.Add(lector[2]); 
                        }
                        if (lector[1].ToString().Equals("Viernes"))
                        {
                            List_Viernes.Items.Add(lector[2]); 
                        }
                        if (lector[1].ToString().Equals("Sábado"))
                        {
                            List_Sabado.Items.Add(lector[2]); 
                        }
                    }                   
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
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
    public partial class MiPlan : Form
    {
        public MiPlan()
        {
            InitializeComponent();
        }

        private void MiPlan_Load(object sender, EventArgs e)
        {
           
        }
    }
}
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
