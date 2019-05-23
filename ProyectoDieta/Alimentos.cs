<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
﻿using System;
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
<<<<<<< HEAD
        static string cadena_conexion = DatosConexion.cadena;         
=======
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
        //const string cadena_conexion = "server=localhost;port=3306;user id=root;password=hack123;database=nutrid; Allow User Variables=True";
         
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
        public form()
        {
            InitializeComponent();
            
            llenarLista(list_frutas, "frutas");
            llenarLista(list_leguminosas, "leguminosas");
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
            MySqlCommand comd = new MySqlCommand("SELECT * FROM comidas WHERE categoria = ?categoria", conexion);
            comd.Parameters.AddWithValue("?categoria", categoria);
            lista.Items.Clear();
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                        lista.Items.Add(lector[1]);
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
                MySqlCommand comd = new MySqlCommand("INSERT INTO comidas(id, comida, categoria) VALUES(DEFAULT, ?comida, ?categoria)", conexion);
                comd.Parameters.AddWithValue("?comida", txt_comida.Text);
                comd.Parameters.AddWithValue("?categoria", categoria_recibida);
                try
                {
                    conexion.Open();
                    comd.ExecuteNonQuery();
                    conexion.Close();
                    llenarLista(list_frutas, "frutas");
                    llenarLista(list_leguminosas, "leguminosas");
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
    }
}
<<<<<<< HEAD
=======
=======
﻿using System;
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
        const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
        //const string cadena_conexion = "server=localhost;port=3306;user id=root;password=hack123;database=nutrid; Allow User Variables=True";
         
        public form()
        {
            InitializeComponent();
            
            llenarLista(list_frutas, "frutas");
            llenarLista(list_leguminosas, "leguminosas");
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
            MySqlCommand comd = new MySqlCommand("SELECT * FROM comidas WHERE categoria = ?categoria", conexion);
            comd.Parameters.AddWithValue("?categoria", categoria);
            lista.Items.Clear();
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                        lista.Items.Add(lector[1]);
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
                MySqlCommand comd = new MySqlCommand("INSERT INTO comidas(id, comida, categoria) VALUES(DEFAULT, ?comida, ?categoria)", conexion);
                comd.Parameters.AddWithValue("?comida", txt_comida.Text);
                comd.Parameters.AddWithValue("?categoria", categoria_recibida);
                try
                {
                    conexion.Open();
                    comd.ExecuteNonQuery();
                    conexion.Close();
                    llenarLista(list_frutas, "frutas");
                    llenarLista(list_leguminosas, "leguminosas");
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
    }
}
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
