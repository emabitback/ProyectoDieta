using MySql.Data.MySqlClient;
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
    public partial class Misdatos : Form
    {
        String email;
        static string cadena_conexion = DatosConexion.cadenaEma;  
        public Misdatos(String email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void Misdatos_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand c= new MySqlCommand("select correo,nombre_completo,telefono,anio_nacimiento,"+
                                                "sexo,direccion,peso,altura,alergias from Usuarios"+
                                                  " WHERE correo=?correo", conexion);

            c.Parameters.AddWithValue("?correo",email);

            try {
                conexion.Open();
                MySqlDataReader lector = c.ExecuteReader();
                if (lector.HasRows)
                    while (lector.Read())
                    {
                        
                        // Se Cargan los datos del Paciente 
                        txt_email.Text = lector[0].ToString();
                        txt_nombre.Text=lector[1].ToString();
                        txt_tel.Text = lector[2].ToString();
                        txt_anio.Text = lector[3].ToString();
                        txt_sexo.Text = lector[4].ToString();
                        txt_direccion.Text = lector[5].ToString();
                        Double p= Convert.ToDouble(lector[6].ToString());
                        Double a = Convert.ToDouble(lector[7].ToString());
                        txt_IMC.Text=(p/(Math.Pow(a,2))).ToString();
                        txt_peso.Text = p.ToString();
                        txt_altura.Text = a.ToString();
                        txt_alergias.Text = lector[8].ToString();
                    }
                conexion.Close();
            }
            catch(Exception exc){
                MessageBox.Show("Algo ocurrio"+exc);
            }

                 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sexo_Click(object sender, EventArgs e)
        {

        }
    }
}
