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
    public partial class form : Form
    {
        static string cadena_conexion = DatosConexion.cadenaEma;         
        public form()
        {
            InitializeComponent();
            
            llenarLista(list_frutas,"frutas");
            llenarLista(list_leguminosas,"leguminosas");
            llenarLista(list_cereales, "cereales");
        }

        private void form_Load(object sender, EventArgs e)
        {
            cmb_categoria.SelectedIndex = 0;
        }
        void llenarLista(ListBox lista, string categoria)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT nombre FROM comidas WHERE categoria=?categoria", conexion);
            comd.Parameters.AddWithValue("?categoria",categoria);
            lista.Items.Clear();
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                        lista.Items.Add(lector[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            string categoria_recibida;


            if (cmb_categoria.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona una categororia");
            }
            else
            {


                if (cmb_categoria.SelectedIndex == 1)
                    categoria_recibida = "frutas";
                else if (cmb_categoria.SelectedIndex == 2)
                    categoria_recibida = "leguminosas";
                else
                    categoria_recibida = "cereales";
                MySqlCommand comd = new MySqlCommand("INSERT INTO comidas(categoria,nombre) VALUES(?categoria, ?comida)", conexion);
                comd.Parameters.AddWithValue("?comida", txt_comida.Text);
                comd.Parameters.AddWithValue("?categoria", categoria_recibida);
                try
                {
                    conexion.Open();
                    comd.ExecuteNonQuery();
                    conexion.Close();
                    llenarLista(list_frutas,"frutas");
                    llenarLista(list_leguminosas,"leguminosas");
                    llenarLista(list_cereales, "cereales");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
            cmb_categoria.SelectedIndex = 0;
            txt_comida.Clear();
           
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Comprobar que no esten Vacios
            if (txt_nombreAlimento_eliminar.Text != "" && combo_categoria_eliminar.SelectedIndex > 0)
            {
                String nombre_alimento = txt_nombreAlimento_eliminar.Text;
                String categoria="";
                int cat =
                    combo_categoria_eliminar.SelectedIndex;
                //Conocer que categoria se Selecciono 
                if (cat == 1)
                    categoria = "frutas";

                if (cat == 2)
                    categoria = "leguminosas";

                if (cat == 31)
                    categoria = "cereales";

                if (DAO.eliminarAlimento(nombre_alimento, categoria)) // Si se borro regresa True
                    MessageBox.Show("Alimento Eliminado");
                else
                    MessageBox.Show("Ocurrio un problema, intente más tarde.");

                //Actualizar las Listas
                llenarLista(list_frutas, "frutas");
                llenarLista(list_leguminosas, "leguminosas");
                llenarLista(list_cereales, "cereales");

                txt_nombreAlimento_eliminar.Clear();
                combo_categoria_eliminar.SelectedIndex = 0;

            }
                //Si estan vacios hacer esto
            else
                MessageBox.Show("Ingresa el nombre a eliminar y selecciona una categoria");
           


        }        
    }
}
