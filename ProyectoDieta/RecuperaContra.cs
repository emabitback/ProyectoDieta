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
    public partial class RecuperaContra : MaterialSkin.Controls.MaterialForm
    {
        static string cadena_conexion = DatosConexion.cadena;         

        public RecuperaContra()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            string correo = txt_correo.Text;
            MySqlCommand comd = new MySqlCommand("SELECT pregunta,respuesta FROM usrs_login WHERE correo = ?correo");
            comd.Parameters.AddWithValue("?correo", correo);
            comd.Connection = conexion;
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            MySqlDataReader lector = comd.ExecuteReader();
            try
            {
                lector.Read();
                if (lector.HasRows)
                {
                    lbl_pregunta.Text = lector[0].ToString();
                }
                else
                {
                    MessageBox.Show("El dato dado no se encuentra registrado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Se ha producido un error" + err + ".");
            }
           
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            string respuesta = txt_respuesta.Text;
            string correo = txt_correo.Text;
            MySqlCommand comd = new MySqlCommand("SELECT correo,psw,rol,pregunta,respuesta, CONVERT(AES_DECRYPT(psw, respuesta), CHARACTER)  FROM usrs_login WHERE correo = ?correo");
            comd.Parameters.AddWithValue("?correo", correo);
            comd.Connection = conexion;
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            MySqlDataReader lector = comd.ExecuteReader();
            try
            {
                if (lector.HasRows)
                {
                    lector.Read();
                    if (respuesta == lector[4].ToString())
                    {
                        MessageBox.Show("Tu contraseña es la siguiente:" + lector[5].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Los valores dados no coinciden.");
                    }
                }
                else
                {
                    MessageBox.Show("El dato dado no se encuentra registrado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Se ha producido un error" + err + ".");
            }
        }

        private void RecuperaContra_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
