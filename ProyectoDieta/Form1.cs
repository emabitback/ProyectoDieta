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
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
            string correo = txt_correo.Text;
            string psw = txt_pws.Text;
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
                    MessageBox.Show("Se leyó la contra");
                    if (psw == lector[5].ToString())
                    {
                        if(lector[2].ToString().Equals("USR")) {                                                    
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
