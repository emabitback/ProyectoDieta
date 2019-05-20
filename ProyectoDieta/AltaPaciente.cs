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
       // const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
       // const string cadena_conexion = "server=localhost;port=3306;user id=root;password=hack123;database=nutrid; Allow User Variables=True";
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=devayper360;database=nutrid; Allow User Variables=True";
        public AltaPaciente()
        {
            InitializeComponent();
        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            MessageBox.Show(txt_correo.Text);
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
                MessageBox.Show(ex + ".");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txt_psw.Clear();
            textBox1.Clear();
            txt_correo.Clear();
            txt_nombre.Clear();
            txt_apep.Clear();
            txt_apem.Clear();
            txt_telefono.Clear();
            txt_nacimiento.Clear();
            txt_direccion.Clear();
               // comd.Parameters.AddWithValue("?sexo", sexo);
            txt_peso.Clear();
            txt_altura.Clear();
            txt_alergias.Clear();

        }
    }
}
