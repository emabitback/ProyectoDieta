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
    public partial class AltaPaciente : Form
    {
       
        static string cadena_conexion = DatosConexion.cadena;
        public AltaPaciente()
        {

            InitializeComponent();
        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private bool existeUsuario(string correo)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM usrs_login WHERE correo = ?correo", conexion);
            comd.Parameters.AddWithValue("?correo", correo);
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())                
                        return true;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR:" + ex.Message);
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (existeUsuario(txt_correo.Text))
            {
                MessageBox.Show("Ya está registrado un usuario con ese correo");
            }
            else
            {
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = cadena_conexion;
                //obteniendo el sexo desde el formulario
                string sexo;
                if (rbt_masculino.Checked)
                    sexo = "Masculino";
                else
                    sexo = "Femenino";
                //obteniendo la pregunta elegida desde el formulario
                string pregunta;
                if (cmb_pregunta.SelectedIndex == 0)
                    pregunta = "¿Cuál fue tu primer número?";
                else if (cmb_pregunta.SelectedIndex == 1)
                    pregunta = "¿Nombre de tu mascota?";
                else
                    pregunta = "Comida favorita";

                MySqlCommand comd = new MySqlCommand("INSERT INTO usrs_login(correo, psw, rol, pregunta, respuesta)"
                    + "VALUES(?correo, aes_encrypt(?psw, ?respuesta), 'USR', ?pregunta , ?respuesta)", conexion);

                comd.Parameters.AddWithValue("?correo", txt_correo.Text);
                comd.Parameters.AddWithValue("?psw", txt_psw.Text);
                comd.Parameters.AddWithValue("?pregunta", pregunta);
                comd.Parameters.AddWithValue("?respuesta", txt_respuesta.Text);
                try
                {
                    conexion.Open();

                    comd.ExecuteNonQuery();
                    comd = new MySqlCommand("INSERT INTO usrs_data(correo, nombre, apep, apem, telefono, nacimiento, direccion, sexo, peso, altura, alergias"
                        + ") VALUES(?correo, ?nombre, ?apep, ?apem, ?telefono, ?nacimiento, ?direccion, ?sexo, ?peso, ?altura, ?alergias)", conexion);
                    comd.Parameters.AddWithValue("?correo", txt_correo.Text);
                    comd.Parameters.AddWithValue("?nombre", txt_nombre.Text);
                    comd.Parameters.AddWithValue("?apep", txt_apep.Text);
                    comd.Parameters.AddWithValue("?apem", txt_apem.Text);
                    comd.Parameters.AddWithValue("?telefono", txt_telefono.Text);
                    comd.Parameters.AddWithValue("?nacimiento", txt_nacimiento.Text);
                    comd.Parameters.AddWithValue("direccion", txt_direccion.Text);
                    comd.Parameters.AddWithValue("?sexo", sexo);
                    comd.Parameters.AddWithValue("?peso", txt_peso.Text);
                    comd.Parameters.AddWithValue("?altura", txt_altura.Text);
                    comd.Parameters.AddWithValue("?alergias", txt_alergias.Text);

                    comd.ExecuteNonQuery();
                    MessageBox.Show("Registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        private void AltaPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
