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
        static string cadena_conexion = DatosConexion.cadenaEma;         

        public RegistrarDietacs()
        {
            InitializeComponent();
        }

        private void RegistrarDietacs_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM Usuarios WHERE rol='P'", conexion);
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
            MySqlCommand comd = new MySqlCommand("SELECT nombre FROM comidas WHERE categoria = ?categoria", conexion);
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
                        cmb_alimento.Items.Add(lector[0]);
                    cmb_alimento.SelectedIndex = 0;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
        private bool existePlan(string correo, string dia, string comida)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("select t2.nombre from dietas as t1 inner                          join comidas as t2 where t1.id_comida=t2.id_comida"+
                                    " and correo=?correo and t1.dia=?dia", conexion);
            comd.Parameters.AddWithValue("?comida", comida);
            comd.Parameters.AddWithValue("?dia", dia);
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
                MessageBox.Show("ERR: --------" + ex.Message);
            }
            return false;
        }
        private void btn_asignar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("INSERT INTO dietas(correo, dia,id_comida) VALUES(?correo,?dia,?comida)", conexion);
            MySqlCommand com = new MySqlCommand("SELECT id_comida from comidas where nombre='"+cmb_alimento.SelectedItem.ToString()+"'", conexion);

          
            comd.Parameters.AddWithValue("?correo", cmb_correos.SelectedItem.ToString());
            comd.Parameters.AddWithValue("?dia", cmb_dia.SelectedItem.ToString());
            try
            {
                conexion.Open();
                MySqlDataReader lector1 = com.ExecuteReader();
                if (lector1.HasRows)
                {
                    while (lector1.Read())
                    {
                        comd.Parameters.AddWithValue("?comida", lector1[0]);
                    }
                }
                conexion.Close();
                conexion.Open();
                comd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Plan agregado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
