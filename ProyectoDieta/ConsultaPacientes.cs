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
        static string cadena_conexion = DatosConexion.cadenaEma;
        public DataTable regresaTabla() {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlDataAdapter adap = new MySqlDataAdapter("SELECT correo,nombre_completo,telefono,anio_nacimiento,direccion,sexo,peso,altura,alergias FROM Usuarios where rol='P'", conexion);
            DataTable tabla = new DataTable();          
            adap.Fill(tabla);
            return tabla;           
        }
    }
}
