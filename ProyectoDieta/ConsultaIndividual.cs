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
    public partial class ConsultaIndividual : Form
    {
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
        public ConsultaIndividual()
        {
            InitializeComponent();
        }


        private void ConsultaIndividual_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM usrs_data", conexion);

            cmb_correos.Items.Clear();
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                        cmb_correos.Items.Add(lector[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            //cmb_correos
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT * FROM usrs_data WHERE correo = ?correo", conexion);
            comd.Parameters.AddWithValue("?correo", cmb_correos.Text);
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                    {
                        txt_nombre.Text = lector[1].ToString();
                        txt_apep.Text = lector[2].ToString();
                        txt_apem.Text = lector[3].ToString();
                        txt_telefono.Text = lector[4].ToString();
                        txt_nacimiento.Text = lector[5].ToString();
                        txt_direccion.Text = lector[6].ToString();
                        if (lector[7].ToString().Equals("Masculino")) {
                            rbt_masculino.Checked = true;
                            rbt_femenino.Checked = false;
                        }

                        else
                        {
                            rbt_masculino.Checked = false;
                            rbt_femenino.Checked = true;
                        }
                        txt_peso.Text = lector[8].ToString();
                        txt_altura.Text = lector[9].ToString();
                        txt_alergias.Text = lector[10].ToString();                     
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
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
            try
            {
               
                MySqlCommand comd = new MySqlCommand("UPDATE usrs_data SET nombre = ?nombre, apep = ?apep, apem = ?apem, telefono = ?telefono, nacimiento = ?nacimiento," 
                    + "direccion = ?direccion, sexo = ?sexo, peso = ?peso, altura = ?altura, alergias = ?alergias WHERE correo = ?correo", conexion);
                
                comd.Parameters.AddWithValue("?correo", cmb_correos.Text);
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
                conexion.Open();
                comd.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + ".");
            }
        }

        private void cmb_correos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
