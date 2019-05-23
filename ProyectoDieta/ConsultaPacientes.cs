<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProyectoDieta
{
    class ConsultaPacientes
    {
<<<<<<< HEAD
        static string cadena_conexion = DatosConexion.cadena;
        public DataTable regresaTabla() {
=======
        public DataTable regresaTabla() {
            const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM usrs_data", conexion);
            DataTable tabla = new DataTable();          
            adap.Fill(tabla);
            return tabla;           
        }
    }
}
<<<<<<< HEAD
=======
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProyectoDieta
{
    class ConsultaPacientes
    {
        public DataTable regresaTabla() {
            const string cadena_conexion = "server=localhost;port=3306;user id=root;password=;database=nutrid; Allow User Variables=True";
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM usrs_data", conexion);
            DataTable tabla = new DataTable();          
            adap.Fill(tabla);
            return tabla;           
        }
    }
}
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
