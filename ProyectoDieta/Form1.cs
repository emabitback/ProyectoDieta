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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        static string cadena_conexion = DatosConexion.cadenaEma;
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {


            if ((txt_correo.Text == "" && txt_pws.Text == "")
                        || txt_pws.Text == "" || txt_correo.Text=="") 
            {
                
                MessageBox.Show("Introduzca sus datos en los campos faltantes. \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String email = txt_correo.Text;
                String pass = txt_pws.Text;

                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = cadena_conexion;
                MySqlCommand comando = new MySqlCommand("select rol,aes_decrypt(psw,(select concat(pregunta,respuesta))) from Usuarios where correo='"+email+"'",conexion);
                String rol = "", psw = "";
                try
                {
                    conexion.Open();
                    MySqlDataReader myreader = comando.ExecuteReader();
                    if (myreader.HasRows)
                    {
                        while (myreader.Read())
                        {
                            rol = myreader.GetString(0);
                            psw = myreader.GetString(1);
                        }
                    }

                    if (psw == pass)
                    {
                        if (rol.Equals("A"))
                        {
                            MenuNutriologo mn = new MenuNutriologo();
                            mn.Show();
                            this.Hide();
                            txt_correo.Clear();
                            txt_pws.Clear();

                        }
                        else
                        {
                            MenuPaciente mp = new MenuPaciente(email);
                            mp.Show();
                            this.Hide();
                            txt_correo.Clear();
                            txt_pws.Clear();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Su email o su contraseña no es correcta \n","Verificar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                    
                }
                catch (Exception er)
                {
                    //MessageBox.Show("Problemas al Inicar sesion  \n" + er);
                    MessageBox.Show("Problemas al Iniciar sesión \n", "Ups !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                   
            }
            

        }



        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            new RecuperaContra().Show();
        }
    }
}