using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ProyectoDieta
{
    public class DAO
    {
        static string cadena_conexion = DatosConexion.cadenaEma;


        public static void insertarUsuario(
            String correo, String psw, char rol, String nombre, String telefono,
            int anio_nacimiento, String direccion, char sexo, Double peso,Double altura,
            String alergias, String pregunta, String respuesta
            )
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comand;
            try
            {
                conexion.Open();
                String clave = pregunta + respuesta;

                comand = new MySqlCommand("insert into Usuarios(correo,psw,rol,nombre_completo,telefono," +
                     "anio_nacimiento,direccion,sexo,peso,altura,alergias,pregunta,respuesta)" +
                "values(?correo,aes_encrypt(?psw, ?clave),?rol,?nombre,?telefono,?anio_nacimiento," +
                      " ?direccion,?sexo,?peso,?altura,?alergias,?pregunta,?respuesta)"
                      , conexion);

                comand.Parameters.AddWithValue("?correo", correo);
                comand.Parameters.AddWithValue("?psw", psw);
                comand.Parameters.AddWithValue("?clave", clave);
                comand.Parameters.AddWithValue("?rol", rol);
                comand.Parameters.AddWithValue("?nombre", nombre);
                comand.Parameters.AddWithValue("?telefono", telefono);
                comand.Parameters.AddWithValue("?anio_nacimiento", anio_nacimiento);
                comand.Parameters.AddWithValue("?direccion", direccion);
                comand.Parameters.AddWithValue("?sexo", sexo);
                comand.Parameters.AddWithValue("?peso", Convert.ToDouble(peso));
                comand.Parameters.AddWithValue("?altura", Convert.ToDouble(altura));
                comand.Parameters.AddWithValue("?alergias", alergias);
                comand.Parameters.AddWithValue("?pregunta", pregunta);
                comand.Parameters.AddWithValue("?respuesta", respuesta);

                comand.ExecuteNonQuery();
            } //fin try
            catch (Exception ex)
            {
               //MessageBox.Show("----" + ex.Message);

            }
            conexion.Close();
        } // fin metodo insertarUsuario


        public static bool actualizarUsuario(String correo,String nombre,int anio_nacimiento,char sexo,String tel,
            Double peso,Double altura,String alergias,String direccion)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;

            try
            {
                conexion.Open();
                MySqlCommand comd = new MySqlCommand("UPDATE Usuarios SET "+
                        "nombre_completo=?nombre_completo,telefono=?tel,anio_nacimiento=?anio_nacimiento"
                    + ",direccion=?direccion,sexo=?sexo,peso=?peso,altura=?altura,alergias=?alergias "+
                "WHERE correo=?correo", conexion);

               
                comd.Parameters.AddWithValue("?nombre_completo",nombre);
                comd.Parameters.AddWithValue("?tel",tel);
                comd.Parameters.AddWithValue("?anio_nacimiento",anio_nacimiento);
                comd.Parameters.AddWithValue("?direccion",direccion);
                comd.Parameters.AddWithValue("?sexo",sexo);
                comd.Parameters.AddWithValue("?peso",peso);
                comd.Parameters.AddWithValue("?altura",altura);
                comd.Parameters.AddWithValue("?alergias",alergias);
                comd.Parameters.AddWithValue("?correo", correo);
               
                comd.ExecuteNonQuery();
                return true;
               // MessageBox.Show("exitoso");
                
            } //fin try
            catch (Exception ex)
            {
                return false;   
                //MessageBox.Show("----" + ex.Message);
            }
        } // fin metodo actualizarUsuario

        public static bool eliminarAlimento(String nombre_alimento, String categoria)
        {
            MySqlConnection conexion3 = new MySqlConnection();
            conexion3.ConnectionString = cadena_conexion;
            try
            {
                conexion3.Open();
                MySqlCommand comandoDeleteAlimento = 
                        new MySqlCommand("delete from comidas"+
                             " where nombre=?nombre and categoria=?categoria",conexion3);
                comandoDeleteAlimento.Parameters.AddWithValue("?nombre",nombre_alimento);
                comandoDeleteAlimento.Parameters.AddWithValue("?categoria",categoria);
                comandoDeleteAlimento.ExecuteNonQuery();
                return true;
            }
            catch (Exception excep)
            {
                return false;
            }


            conexion3.Close();

        }


        public static bool eliminarUsuario(String email)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            try
            {
                conexion.Open();
                MySqlCommand comandoDelete = new MySqlCommand("delete from Usuarios where rol='P' and correo=?correo", conexion);
                comandoDelete.Parameters.AddWithValue("?correo",email);
                comandoDelete.ExecuteNonQuery();
                return true;
            }catch(Exception excep){
                return false;
            }


            conexion.Close();

        }


        public static String buscarDatosParaRecuperacion(String email){
              MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
            MySqlCommand comd = new MySqlCommand("SELECT CONCAT(pregunta,respuesta) FROM Usuarios"+
                                                    "WHERE correo = ?correo");
            MySqlCommand preguntas = new MySqlCommand(
                                                "SELECT DISTINTIC pregunta from Usuarios", conexion);
            comd.Parameters.AddWithValue("?correo",email);
            String key = "";
            try
            {
                conexion.Open();
                MySqlDataReader lector = comd.ExecuteReader();
                lector.Read();
                if (lector.HasRows)
                {
                    key = lector[0].ToString();
                }
                return key;
            }
            catch (Exception err)
            {
                //MessageBox.Show("Se ha producido un error" + err + ".");
                return key;
            }
           
        }
    }



   


} // fin de NameSpace               
        
