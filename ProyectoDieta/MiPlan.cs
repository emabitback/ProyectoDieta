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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace ProyectoDieta
{
    public partial class MiPlan : Form
    {
        static string cadena_conexion = DatosConexion.cadenaEma;         

        String correo;
        public MiPlan(String correo)
        {
            this.correo = correo;
            InitializeComponent();
        }
        

        private void MiPlan_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadena_conexion;
           // MySqlCommand comd = new MySqlCommand("SELECT * FROM dietas WHERE correo=?correo", conexion);
            MySqlCommand c = new MySqlCommand("select t1.dia,t2.nombre from dietas as t1 inner join comidas as t2 where t1.id_comida=t2.id_comida and correo=?correo", conexion);

            c.Parameters.AddWithValue("?correo",correo);
            List_Lunes.Items.Clear();
            List_Martes.Items.Clear();
            List_Miercoles.Items.Clear();
            List_Jueves.Items.Clear();
            List_Viernes.Items.Clear();
            List_Sabado.Items.Clear();       

            try
            {
                conexion.Open();
                MySqlDataReader lector = c.ExecuteReader();
                //llenando la list_box
                if (lector.HasRows)
                    while (lector.Read())
                    {
                        if (lector[0].ToString().Equals("Lunes")) { List_Lunes.Items.Add(lector[1]); }

                        if (lector[0].ToString().Equals("Martes"))
                        {
                            List_Martes.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Miércoles"))
                        {
                            List_Miercoles.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Jueves"))
                        {
                            List_Jueves.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Viernes"))
                        {
                            List_Viernes.Items.Add(lector[1]); 
                        }
                        if (lector[0].ToString().Equals("Sábado"))
                        {
                            List_Sabado.Items.Add(lector[1]); 
                        }
                    }                   
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void List_Lunes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Lunes = ""; String Jueves = "";
            String Martes = ""; String Viernes = "";
            String Miercoles = ""; String Sabado = "";

            foreach (object iteem in List_Lunes.Items)
            {
                Lunes += iteem.ToString() + "\n";

            }


            foreach (object iteem in List_Martes.Items)
            {
                Martes += iteem.ToString() + "\n";

            }

            foreach (object iteem in List_Miercoles.Items)
            {
                Miercoles += iteem.ToString() + "\n";

            }
            foreach (object iteem in List_Jueves.Items)
            {
                Jueves += iteem.ToString() + "\n";

            }
            foreach (object iteem in List_Viernes.Items)
            {
                Viernes += iteem.ToString() + "\n";

            }

            foreach (object iteem in List_Sabado.Items)
            {
                Sabado += iteem.ToString() + "\n";

            }
            String nombre = DAO.buscarNombre(this.correo);
           

            Document doc = new Document();

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("C:/Users/Ema/Documents/Visual Studio 2013/Projects/ProyectoDieta/Mi_plan.pdf", FileMode.Create));
            doc.Open();

            PdfPTable tabla = new PdfPTable(3);

            PdfPCell celda_nombrePaciente = new PdfPCell(new Paragraph("Nombre del Paciente"));
            celda_nombrePaciente.Border = 0;

            
            
                PdfPCell  celda_nombrePaciente2 = new PdfPCell(new Paragraph(nombre));
                celda_nombrePaciente2.Colspan = 2;
                celda_nombrePaciente2.Border = 0;
            
           



            PdfPCell celda_fecha = new PdfPCell(new Paragraph("Fecha"));
            DateTime thisDay = DateTime.Today;
            
            PdfPCell celda_fecha2 = new PdfPCell(new Paragraph(thisDay.ToShortDateString()));
            celda_fecha2.Colspan = 2;
            celda_fecha.Border = 0;
            celda_fecha2.Border = 0;

            PdfPCell celdaBlanco = new PdfPCell(new Paragraph("    "));
            celdaBlanco.Colspan = 3;
            celdaBlanco.Rowspan = 2;
            celdaBlanco.Border = 0;

            PdfPCell celda_dia1 = new PdfPCell(new Paragraph("LUNES"));
            PdfPCell celda_dia2 = new PdfPCell(new Paragraph("MARTES"));
            PdfPCell celda_dia3 = new PdfPCell(new Paragraph("MIERCOLES"));

            PdfPCell celdaLunes = new PdfPCell(new Paragraph(Lunes));
            celdaLunes.Rowspan = 2;

            PdfPCell celdaMartes = new PdfPCell(new Paragraph(Martes));
            celdaMartes.Rowspan = 2;

            PdfPCell celdaMiercoles = new PdfPCell(new Paragraph(Miercoles));
            celdaMiercoles.Rowspan = 2;

            PdfPCell celdaBlanco2 = new PdfPCell(new Paragraph("    "));
            celdaBlanco2.Colspan = 3;
            celdaBlanco2.Rowspan = 2;
            celdaBlanco2.Border = 0;

            PdfPCell celda_dia4 = new PdfPCell(new Paragraph("JUEVES"));
            PdfPCell celda_dia5 = new PdfPCell(new Paragraph("VIERNES"));
            PdfPCell celda_dia6 = new PdfPCell(new Paragraph("SABADO"));

            PdfPCell celdaJueves = new PdfPCell(new Paragraph(Jueves));
            celdaJueves.Rowspan = 2;

            PdfPCell celdaViernes = new PdfPCell(new Paragraph(Viernes));
            celdaViernes.Rowspan = 2;

            PdfPCell celdaSabado = new PdfPCell(new Paragraph(Sabado));
            celdaSabado.Rowspan = 2;

            //Se añaden las celdas a la Tabla
            tabla.AddCell(celda_nombrePaciente);
            tabla.AddCell(celda_nombrePaciente2);
            tabla.AddCell(celda_fecha);
            tabla.AddCell(celda_fecha2);
            tabla.AddCell(celdaBlanco);
            //titulos de dias
            tabla.AddCell(celda_dia1);
            tabla.AddCell(celda_dia2);
            tabla.AddCell(celda_dia3);
           

            //
            tabla.AddCell(celdaLunes);
            tabla.AddCell(celdaMartes);
            tabla.AddCell(celdaMiercoles);
            tabla.AddCell(celdaBlanco2);
            tabla.AddCell(celda_dia4);
            tabla.AddCell(celda_dia5);
            tabla.AddCell(celda_dia6);

            tabla.AddCell(celdaJueves);
            tabla.AddCell(celdaViernes);
            tabla.AddCell(celdaSabado);



            doc.Add(tabla);
            doc.Close();
            wri.Close();

            //System.Diagnostics.Process.Start(@"E:/Credencial.pdf");
            System.Diagnostics.Process.Start(@"C:/Users/Ema/Documents/Visual Studio 2013/Projects/ProyectoDieta/Mi_plan.pdf");





        }
    }
}
