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
    public partial class RegistrarDietacs : Form
    {
<<<<<<< HEAD
        static string cadena_conexion = DatosConexion.cadena;         
=======
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629

        public RegistrarDietacs()
        {
            InitializeComponent();
        }

        private void RegistrarDietacs_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM usrs_data", conexion);
            cmb_correos.Items.Clear();
            try
            {
                cmb_dia.SelectedIndex = 0;
                cmb_categoria.SelectedIndex = 0;
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                {
                    while (lector.Read())
                        cmb_correos.Items.Add(lector[0]);
                    cmb_correos.SelectedIndex = 0;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            

        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT * FROM comidas WHERE categoria = ?categoria", conexion);
            comd.Parameters.AddWithValue("?categoria", cmb_categoria.Text);
            cmb_alimento.Items.Clear();
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                {
                    while (lector.Read())
                        cmb_alimento.Items.Add(lector[1]);
                    cmb_alimento.SelectedIndex = 0;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("INSERT INTO dieta(correo, dia, comida) VALUES(?correo,?dia,?comida)", conexion);
            comd.Parameters.AddWithValue("?comida", cmb_alimento.Text);
            comd.Parameters.AddWithValue("?correo", cmb_correos.Text);
            comd.Parameters.AddWithValue("?dia", cmb_dia.Text);
            try
            {
                conexion.Open();
                comd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se han guardado los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
