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
        static string cadena_conexion = DatosConexion.cadena;
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            string correo = txt_correo.Text;
            string psw = txt_pws.Text;
            MySqlCommand comd = new MySqlCommand("SELECT correo,psw,rol,pregunta,respuesta, CONVERT(AES_DECRYPT(psw, respuesta), CHARACTER)  FROM usrs_login WHERE correo = ?correo");
            comd.Parameters.AddWithValue("?correo", correo);
            comd.Connection = conexion;
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            MySqlDataReader lector = comd.ExecuteReader();
            if (txt_correo.Text == "" && txt_pws.Text == "")
            {
                MessageBox.Show("hay campos vacios favor de verificar");
            }
            else
            {
                try
                   {
                        if (lector.HasRows)
                        {

                            lector.Read();
                            if (psw == lector[5].ToString())
                            {
                            if (lector[2].ToString().Equals("USR"))
                            {
                                new MenuPaciente(lector[0].ToString()).Show();
                                conexion.Close();
                                this.Hide();
                            }
                            else
                                {
                                conexion.Close();
                                new MenuNutriologo().Show();
                                this.Hide();
                                }
                            }
                            else
                                {
                            MessageBox.Show("Los valores dados no coinciden.");
                            txt_correo.Clear();
                            txt_pws.Clear();
                                }
                           }
                    else
                        {
                        MessageBox.Show("El dato dado no se encuentra registrado");
                        txt_correo.Clear();
                        txt_pws.Clear();
                        }
                }
                    catch (Exception err)
                    {
                    MessageBox.Show("Se ha producido un error" + err + ".");
                     }
            }
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            new RecuperaContra().Show();
        }
    }
}
