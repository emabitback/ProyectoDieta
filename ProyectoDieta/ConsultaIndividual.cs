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
        static string cadena_conexion = DatosConexion.cadenaEma;
        public ConsultaIndividual()
        {
            InitializeComponent();
        }


        private void ConsultaIndividual_Load(object sender, EventArgs e)
        {
            txt_nombre.Enabled = false;
            txt_nacimiento.Enabled = false;
            txt_telefono.Enabled = false;
            txt_peso.Enabled=false;
            txt_altura.Enabled = false;
            txt_alergias.Enabled = false;
            txt_direccion.Enabled = false;


            
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT correo FROM Usuarios where rol='P'", conexion);

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
        private void txt_numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumero(e);
        }

        private void text_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.sololetras(e);
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand
             ("select nombre_completo,telefono,anio_nacimiento,direccion,sexo,peso,altura,alergias"+
                 " from Usuarios WHERE correo=?correo",conexion);
            comd.Parameters.AddWithValue("?correo",cmb_correos.SelectedItem.ToString());
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                txt_nombre.Enabled = true;
                txt_nacimiento.Enabled = true;
                txt_telefono.Enabled = true;
                txt_peso.Enabled = true;
                txt_altura.Enabled = true;
                txt_alergias.Enabled = true;
                txt_direccion.Enabled = true;

                if (lector.HasRows)
                    while (lector.Read())
                    {
                        txt_nombre.Text = lector[0].ToString();
                        txt_telefono.Text = lector[1].ToString();
                        txt_nacimiento.Text = lector[2].ToString();
                        txt_direccion.Text = lector[3].ToString();
                       // MessageBox.Show(lector[4].ToString());
                        if (lector[4].ToString().Equals("M"))
                            rbt_masculino.Checked = true;
                        else
                            rbt_femenino.Checked = true;
                         

                        txt_peso.Text = lector[5].ToString();
                        txt_altura.Text = lector[6].ToString();
                        txt_alergias.Text = lector[7].ToString();                     
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
           //Modificar
            if (txt_nombre.Text != "" && txt_telefono.Text != "" && txt_nacimiento.Text != ""
                && txt_direccion.Text != "" && txt_peso.Text != "" && txt_altura.Text != ""
                && txt_alergias.Text != "")
            {
                String correo = cmb_correos.SelectedItem.ToString();
                String nombre = txt_nombre.Text;
                String tel = txt_telefono.Text;
                int anio = Convert.ToInt32(txt_nacimiento.Text);
                String direccion = txt_direccion.Text;
                char sexo = ' ';
                if (rbt_masculino.Checked == true)
                    sexo = 'M';
                else
                    sexo = 'F';

                Double peso = Convert.ToDouble(txt_peso.Text);
                Double altura = Convert.ToDouble(txt_altura.Text);
                String alergias = txt_alergias.Text;

                //  DAO.actualizarUsuario(correo, nombre, anio, sexo, tel, peso, altura, alergias, direccion);



                if (DAO.actualizarUsuario(correo, nombre, anio, sexo, tel, peso, altura, alergias, direccion))
                    MessageBox.Show("Registro Modificado");
                else
                    MessageBox.Show("Ocurrio un error, Intente de nuevo.");
            }// fin If de validacion campos Vacios
            else { MessageBox.Show("Todos los campos son requeridos."); }

            
             
        }

        private void cmb_correos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminarPaciente_Click(object sender, EventArgs e)
        {
            if (DAO.eliminarUsuario(cmb_correos.SelectedItem.ToString()))
            {
                MessageBox.Show("Paciente Eliminado");
            }
            else
                MessageBox.Show("Hubo Un error al Eliminar el Paciente");

            txt_nombre.Clear();
            txt_nacimiento.Clear();
            txt_telefono.Clear();
            txt_peso.Clear();
            txt_altura.Clear();
            txt_alergias.Clear();
            txt_direccion.Clear();

        }
    }
}
