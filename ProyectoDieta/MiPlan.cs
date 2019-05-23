using System;
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
        static string cadena_conexion = DatosConexion.cadena;         

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
