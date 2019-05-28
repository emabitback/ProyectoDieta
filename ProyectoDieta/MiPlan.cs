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
        static string cadena_conexion = DatosConexion.cadenaEma;         

        String correo;
        public MiPlan(String correo)
        {
            this.correo = correo;
            InitializeComponent();
        }

        private void MiPlan_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
           // MySqlCommand comd = new MySqlCommand("SELECT * FROM dietas WHERE correo=?correo", conexion);
            MySqlCommand c = new MySqlCommand("select t1.dia,t2.nombre from dietas as t1 inner join comidas as t2 where t1.id_comida=t2.id_comida and correo=?correo", conexion);

            c.Parameters.AddWithValue("?correo",correo);
            List_Lunes.Items.Clear();
            List_Martes.Items.Clear();
            List_Miercoles.Items.Clear();
            List_Jueves.Items.Clear();
            List_Viernes.Items.Clear();
            List_Sabado.Items.Clear();       

            try
            {
                conexion.Open();
                MySqlDataReader lector = c.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                    {
                        if (lector[0].ToString().Equals("Lunes")) { List_Lunes.Items.Add(lector[1]); }

                        if (lector[0].ToString().Equals("Martes"))
                        {
                            List_Martes.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Miércoles"))
                        {
                            List_Miercoles.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Jueves"))
                        {
                            List_Jueves.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Viernes"))
                        {
                            List_Viernes.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Sábado"))
                        {
                            List_Sabado.Items.Add(lector[1]); 
                        }
                    }                   
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void List_Lunes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
