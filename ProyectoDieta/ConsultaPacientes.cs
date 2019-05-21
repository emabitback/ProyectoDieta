using System;
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
