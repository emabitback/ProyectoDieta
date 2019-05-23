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
        static string cadena_conexion = DatosConexion.cadena;
        public DataTable regresaTabla() {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT * FROM usrs_data", conexion);
            DataTable tabla = new DataTable();          
            adap.Fill(tabla);
            return tabla;           
        }
    }
}
