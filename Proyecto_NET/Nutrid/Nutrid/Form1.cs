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
using System.Security.Cryptography;
using System.IO;
namespace Nutrid
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Simulación placeholder para correo electrónico
        private void txt_usuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_usuario.Text == "Correo electrónico")
                txt_usuario.Text = "";
        }
        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
                txt_usuario.Text = "Correo electrónico";
        }
        //Simulación placeholder para contraseña
        private void txt_psw_Leave(object sender, EventArgs e)
        {
            if (txt_psw.Text == "")
            {
                txt_psw.Text = "Contraseña";
                txt_psw.PasswordChar = '\0';
            }

        }

        private void txt_psw_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_psw.Text == "Contraseña")
            {
                txt_psw.Text = "";
                txt_psw.PasswordChar = '*';
            }

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
            string correo = txt_usuario.Text;
            string psw = txt_psw.Text;
            MySqlCommand comd = new MySqlCommand("SELECT correo,psw,rol,pregunta,respuesta, AES_DECRYPT(psw, respuesta)  FROM usrs_login WHERE correo = ?correo AND rol = 'USR'");
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

                    MessageBox.Show(lector[5].ToString() + "-" + lector[4]);
                     if(psw == lector[5].ToString()) {
                        conexion.Close();
                        MessageBox.Show(lector[5].ToString());                       
                        new MenuNutriologo().Show();
                        this.Hide();
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
 
    }
}
