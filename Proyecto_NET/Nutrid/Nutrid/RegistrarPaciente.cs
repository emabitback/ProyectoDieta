using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Nutrid
{
    public partial class RegistrarPaciente : UserControl
    {
        public RegistrarPaciente()
        {
            InitializeComponent();
        }

        //Simulación de placeholder para correo electrónico
        private void txt_correo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_correo.Text == "Correo electrónico")
                txt_correo.Text = "";   
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
                txt_correo.Text = "Correo electrónico"; 
        }
        //Simulación de placeholder para contraseña
        private void txt_psw_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_psw.Text == "Contraseña")
            {
                txt_psw.Text = "";
                txt_psw.PasswordChar = '*';
            }
        }

        private void txt_psw_Leave(object sender, EventArgs e)
        {
            if (txt_psw.Text == "")
            {
                txt_psw.Text = "Contraseña";
                txt_psw.PasswordChar = '\0';
            }
        }
        //Simulación de placeholder para nombre
        private void txt_nombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_nombre.Text == "Nombre")
                txt_nombre.Text = "";      
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
                txt_nombre.Text = "Nombre";    
        }
        //Simulación de placeholder para apellido paterno
        private void txt_apep_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_apep.Text == "Apellido paterno")
                txt_apep.Text = "";
        }

        private void txt_apep_Leave(object sender, EventArgs e)
        {
            if (txt_apep.Text == "")
                txt_apep.Text = "Apellido paterno";    
        }
        //Simulación de placeholder para apellido materno
        private void txt_apem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_apem.Text == "Apellido materno")
                txt_apem.Text = "";
        }

        private void txt_apem_Leave(object sender, EventArgs e)
        {
            if (txt_apem.Text == "")
                txt_apem.Text = "Apellido materno";   
        }
        //Simulación de placeholder para apellido teléfono
        private void txt_telefono_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_telefono.Text == "Teléfono")
                txt_telefono.Text = "";
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
                txt_telefono.Text = "Teléfono";   
        }
        //Simulación de placeholder para año de nacimiento
        private void txt_nacimiento_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_nacimiento.Text == "Año de nacimiento")
                txt_nacimiento.Text = "";
        }

        private void txt_nacimiento_Leave(object sender, EventArgs e)
        {
            if (txt_nacimiento.Text == "")
                txt_nacimiento.Text = "Año de nacimiento"; 
        }
        //Simulación de placeholder para dirección
        private void txt_direccion_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_direccion.Text == "Dirección")
                txt_direccion.Text = "";
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "")
                txt_direccion.Text = "Dirección";
        }
        //Simulación de placeholder para respuesta a la pregunta
        private void txt_respuesta_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_respuesta.Text == "Respuesta")
                txt_respuesta.Text = "";
        }

        private void txt_respuesta_Leave(object sender, EventArgs e)
        {
            if (txt_respuesta.Text == "")
                txt_respuesta.Text = "Respuesta";
        }
        //Simulación de placeholder para peso
        private void txt_peso_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_peso.Text == "Peso")
                txt_peso.Text = "";
        }

        private void txt_peso_Leave(object sender, EventArgs e)
        {
            if (txt_peso.Text == "")
                txt_peso.Text = "Peso";
        }
        //Simulación de placeholder para altura
        private void txt_altura_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_altura.Text == "Altura")
                txt_altura.Text = "";
        }

        private void txt_altura_Leave(object sender, EventArgs e)
        {
            if (txt_altura.Text == "")
                txt_altura.Text = "Altura";
        }

        private void txt_alergias_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_alergias.Text == "Alergias")
                txt_alergias.Text = "";
        }

        private void txt_alergias_Leave(object sender, EventArgs e)
        {
            if (txt_alergias.Text == "")
                txt_alergias.Text = "Alergias";
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
            
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
        
    }
}
