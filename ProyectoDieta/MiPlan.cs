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


            //variables univerales
            String lunes;
            String Martes;
            String Miercoles;
            String Jueves;
            String viernes;
            String Sabado;
           
            String paciente = "Datos del paciente";
            String nombre;
             String correo;
             String tel;
 
            lunes = List_Lunes.Text;
            Martes = List_Martes.Text;
            Miercoles = List_Miercoles.Text;
            Jueves = List_Jueves.Text;
            viernes = List_Viernes.Text;
            Sabado = List_Sabado.Text;
            nombre = materialLabel1.Text;
            correo = materialLabel1.Text;
            

            // creacion del pdf
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("C:/Users/USER/Desktop/pdf_paciente.pdf", FileMode.Create));

            doc.Open();



            PdfPTable tabla = new PdfPTable(4);
            PdfPCell celdaInicial = new PdfPCell(new Paragraph(paciente, FontFactory.GetFont("bold", 14, BaseColor.WHITE)));
            celdaInicial.Colspan = 4;
            celdaInicial.HorizontalAlignment = Element.ALIGN_CENTER;
            celdaInicial.BackgroundColor = new iTextSharp.text.BaseColor(144, 202, 249);


            // Celda de Imagen
            //iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/Users/USER/Desktop/ad.jpg");
            //PdfPCell celdaImagen = new PdfPCell(imagen);
           // celdaImagen.Rowspan = 5;


            PdfPCell celda_espacioNombre = new PdfPCell(new Paragraph("Nombre del Paciente:"));
            celda_espacioNombre.Colspan = 3;


            PdfPCell celdaCorreo = new PdfPCell(new Paragraph(nombre, FontFactory.GetFont("arial", 12, 1)));
            celdaCorreo.Colspan = 3;
            celdaCorreo.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell celda_espacioCorreos = new PdfPCell(new Paragraph("Correo:"));
            celda_espacioCorreos.Colspan = 3;




            PdfPCell celdaCorreos = new PdfPCell(new Paragraph(correo, FontFactory.GetFont("arial", 12, 1)));
            celdaCorreos.Colspan = 4;
            celdaCorreos.HorizontalAlignment = Element.ALIGN_CENTER;




            PdfPCell celdaLunes = new PdfPCell(new Paragraph("Lunes:", FontFactory.GetFont("arial", 11)));
            celdaLunes.Colspan = 2;


            PdfPCell celdaNocontrol = new PdfPCell(new Paragraph(lunes, FontFactory.GetFont("arial", 12, 1)));
            celdaNocontrol.Colspan = 2;
            celdaNocontrol.HorizontalAlignment = Element.ALIGN_CENTER;

            tabla.AddCell(celdaInicial);
           // tabla.AddCell(celdaImagen);
            tabla.AddCell(celda_espacioNombre);
            tabla.AddCell(celdaCorreo);
            tabla.AddCell(celda_espacioCorreos);
            tabla.AddCell(celdaLunes);
            tabla.AddCell(celdaNocontrol);


            tabla.AddCell(new Paragraph("Martes:", FontFactory.GetFont("arial", 11)));
            PdfPCell celdaMartes = new PdfPCell(new Paragraph(Martes, FontFactory.GetFont("arial", 11, 1)));
            celdaMartes.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celdaMartes);

            tabla.AddCell(new Paragraph("Miercoles:", FontFactory.GetFont("arial", 11)));
            PdfPCell celdaMIercoles = new PdfPCell(new Paragraph(Miercoles, FontFactory.GetFont("arial", 11, 1)));
            celdaMIercoles.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celdaMIercoles);

            tabla.AddCell(new Paragraph("Jueves:", FontFactory.GetFont("arial", 11)));
            PdfPCell celdajueves = new PdfPCell(new Paragraph(Jueves, FontFactory.GetFont("arial", 11, 1)));
            celdajueves.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celdajueves);

            tabla.AddCell(new Paragraph("Viernes:", FontFactory.GetFont("arial", 11)));
            PdfPCell celdaViernes = new PdfPCell(new Paragraph(viernes, FontFactory.GetFont("arial", 11, 1)));
            celdaViernes.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celdaViernes);

            tabla.AddCell(new Paragraph("Sabado:", FontFactory.GetFont("arial", 11)));
            PdfPCell celdasabado = new PdfPCell(new Paragraph(Jueves, FontFactory.GetFont("arial", 11, 1)));
            celdasabado.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.AddCell(celdasabado);

          

  

            doc.Add(tabla);
            MessageBox.Show("se genero con exito! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            doc.Close();
            wri.Close();





        }
    }
}
