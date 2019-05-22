<<<<<<< HEAD
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
using Microsoft.Office.Interop.Excel;
namespace ProyectoDieta
{
    public partial class ListaPacientes : Form
    {
        public ListaPacientes()
        {
            InitializeComponent();
        }

        private void ListaPacientes_Load(object sender, EventArgs e)
        {
            ConsultaPacientes objt = new ConsultaPacientes();
            dataGridView1.DataSource = objt.regresaTabla();       
        }

        private void btn_generarExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Application.Workbooks.Add(true);
            int idxColumna = 0;
            foreach (DataGridViewColumn col in  dataGridView1.Columns) 
            {
                idxColumna++;
                ex.Cells[1, idxColumna] = col.Name;
            }
            int idxFila = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                idxFila++;
                idxColumna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    idxColumna++;
                    ex.Cells[idxFila + 1, idxColumna] = fila.Cells[col.Name].Value;
                }

            }
            ex.Visible = true;
            
        }
    }
}
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
using Microsoft.Office.Interop.Excel;
namespace ProyectoDieta
{
    public partial class ListaPacientes : Form
    {
        public ListaPacientes()
        {
            InitializeComponent();
        }

        private void ListaPacientes_Load(object sender, EventArgs e)
        {
            ConsultaPacientes objt = new ConsultaPacientes();
            dataGridView1.DataSource = objt.regresaTabla();       
        }

        private void btn_generarExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Application.Workbooks.Add(true);
            int idxColumna = 0;
            foreach (DataGridViewColumn col in  dataGridView1.Columns) 
            {
                idxColumna++;
                ex.Cells[1, idxColumna] = col.Name;
            }
            int idxFila = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                idxFila++;
                idxColumna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    idxColumna++;
                    ex.Cells[idxFila + 1, idxColumna] = fila.Cells[col.Name].Value;
                }

            }
            ex.Visible = true;
            
        }
    }
}
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
