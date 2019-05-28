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
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM usrs_login WHERE correo=?correo", conexion);
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

            if (txt_correo.Text != "" && txt_psw.Text != "" && txt_nombre.Text != "" &&
                 txt_telefono.Text != "" &&
                 txt_peso.Text != "" && txt_altura.Text != "" && txt_nacimiento.Text != ""
                 && txt_alergias.Text !="" && (cmb_pregunta.SelectedIndex > 0)
                 && txt_respuesta_recuperacion.Text != "" && txt_nacimiento.Text != "" &&
                 txt_direccion.Text != "") 
       
            {
                char rol=' ';

                String correo=txt_correo.Text;
                String psw=txt_psw.Text;
                String nombre=txt_nombre.Text;
                if (combo_tipoUsuario.SelectedIndex == 0)
                    rol = 'P';
                if (combo_tipoUsuario.SelectedIndex == 1)
                    rol = 'A';
                   
                
                String tel=txt_telefono.Text;
                Double peso =Convert.ToDouble(txt_peso.Text);
                 Double altura =Convert.ToDouble(txt_altura.Text);
                int anio_nacimiento=Convert.ToInt32(txt_nacimiento.Text);
                 String alergias=txt_alergias.Text ;
                 String respuesta_recuperacion=txt_respuesta_recuperacion.Text;
                 String direccion=txt_direccion.Text;

                 char sexo;
                    if (rbt_masculino.Checked)
                        sexo = 'M';
                    else
                        sexo = 'F';

                    String pregunta="";
                    if (cmb_pregunta.SelectedIndex == 1)
                        pregunta = "Cual fue la marca de tu primer celular";
                    if (cmb_pregunta.SelectedIndex == 2)
                        pregunta = "Nombre de tu mascota actual";
                    if (cmb_pregunta.SelectedIndex == 3)
                        pregunta = "Cual es tu comida favorita";


                    DAO.insertarUsuario(correo,psw,rol,nombre,tel,anio_nacimiento,direccion,sexo
                        ,peso,altura,alergias,pregunta,respuesta_recuperacion);
                    
                        
                        MessageBox.Show("Registrado Exitosamente");

                //Limpieza de Campos
                        txt_correo.Clear();
                        txt_nombre.Clear();
                        txt_telefono.Clear();
                        txt_nacimiento.Clear();
                        txt_direccion.Clear();
                        txt_peso.Clear();
                        txt_altura.Clear();
                        txt_alergias.Clear();
                        txt_respuesta_recuperacion.Clear();
                        cmb_pregunta.SelectedIndex = 0;
                        txt_psw.Clear();
                        
                
                    
                }
            
            else { MessageBox.Show("Llena Todos los putos campos Pendejjo"); }
      }

        private void AltaPaciente_Load(object sender, EventArgs e)
        {
            cmb_pregunta.SelectedIndex = 0;
            combo_tipoUsuario.SelectedIndex = 0;
          
        }
      private void txt_numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumero(e);
        }

        private void text_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
           validacion.soloLetras_Espacio(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_correo.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_nacimiento.Clear();
            txt_direccion.Clear();
            txt_peso.Clear();
            txt_altura.Clear();
            txt_alergias.Clear();
            txt_respuesta_recuperacion.Clear();
            cmb_pregunta.SelectedIndex = 0;
            combo_tipoUsuario.SelectedIndex = 0;
            txt_psw.Clear();
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }





        
    }
}
