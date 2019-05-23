namespace ProyectoDieta
{
    partial class ConsultaIndividual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_correos = new System.Windows.Forms.ComboBox();
            this.txt_apem = new System.Windows.Forms.TextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_apep = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_alergias = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.rbt_femenino = new System.Windows.Forms.RadioButton();
            this.rbt_masculino = new System.Windows.Forms.RadioButton();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nacimiento = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(529, 23);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(169, 35);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Ver información";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_correos
            // 
            this.cmb_correos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_correos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_correos.FormattingEnabled = true;
            this.cmb_correos.Items.AddRange(new object[] {
            "--Selecciona una Categoria --",
            "Frutas y verduras",
            "Lugiminosas y alimentos de origen animal",
            "Cerales"});
            this.cmb_correos.Location = new System.Drawing.Point(212, 27);
            this.cmb_correos.Name = "cmb_correos";
            this.cmb_correos.Size = new System.Drawing.Size(267, 28);
            this.cmb_correos.TabIndex = 1;
            this.cmb_correos.SelectedIndexChanged += new System.EventHandler(this.cmb_correos_SelectedIndexChanged);
            // 
            // txt_apem
            // 
            this.txt_apem.Location = new System.Drawing.Point(231, 195);
            this.txt_apem.MaxLength = 30;
            this.txt_apem.Name = "txt_apem";
            this.txt_apem.Size = new System.Drawing.Size(192, 20);
            this.txt_apem.TabIndex = 5;
            this.txt_apem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_letras_KeyPress);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(81, 196);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(128, 19);
            this.materialLabel14.TabIndex = 52;
            this.materialLabel14.Text = "Apellido materno:";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(113, 90);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(0, 19);
            this.materialLabel15.TabIndex = 51;
            // 
            // txt_apep
            // 
            this.txt_apep.Location = new System.Drawing.Point(231, 157);
            this.txt_apep.MaxLength = 30;
            this.txt_apep.Name = "txt_apep";
            this.txt_apep.Size = new System.Drawing.Size(192, 20);
            this.txt_apep.TabIndex = 4;
            this.txt_apep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_apep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_letras_KeyPress);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(81, 158);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(123, 19);
            this.materialLabel12.TabIndex = 49;
            this.materialLabel12.Text = "Apellido paterno:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(81, 124);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(0, 19);
            this.materialLabel13.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_alergias);
            this.groupBox1.Controls.Add(this.txt_altura);
            this.groupBox1.Controls.Add(this.txt_peso);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Location = new System.Drawing.Point(85, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Medicos";
            // 
            // txt_alergias
            // 
            this.txt_alergias.Location = new System.Drawing.Point(91, 63);
            this.txt_alergias.Multiline = true;
            this.txt_alergias.Name = "txt_alergias";
            this.txt_alergias.Size = new System.Drawing.Size(283, 61);
            this.txt_alergias.TabIndex = 13;
            this.txt_alergias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(308, 30);
            this.txt_altura.MaxLength = 4;
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(66, 20);
            this.txt_altura.TabIndex = 12;
            this.txt_altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(111, 28);
            this.txt_peso.MaxLength = 3;
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(65, 20);
            this.txt_peso.TabIndex = 11;
            this.txt_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeros_KeyPress);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(21, 63);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(64, 19);
            this.materialLabel11.TabIndex = 18;
            this.materialLabel11.Text = "Alergias";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(226, 29);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(76, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Altura (m)";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(21, 28);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Peso (KG)";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(117, 264);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(50, 19);
            this.materialLabel7.TabIndex = 45;
            this.materialLabel7.Text = "Sexo :";
            // 
            // rbt_femenino
            // 
            this.rbt_femenino.AutoSize = true;
            this.rbt_femenino.Location = new System.Drawing.Point(313, 264);
            this.rbt_femenino.Name = "rbt_femenino";
            this.rbt_femenino.Size = new System.Drawing.Size(71, 17);
            this.rbt_femenino.TabIndex = 9;
            this.rbt_femenino.TabStop = true;
            this.rbt_femenino.Text = "Femenino";
            this.rbt_femenino.UseVisualStyleBackColor = true;
            // 
            // rbt_masculino
            // 
            this.rbt_masculino.AutoSize = true;
            this.rbt_masculino.Location = new System.Drawing.Point(231, 264);
            this.rbt_masculino.Name = "rbt_masculino";
            this.rbt_masculino.Size = new System.Drawing.Size(76, 17);
            this.rbt_masculino.TabIndex = 8;
            this.rbt_masculino.TabStop = true;
            this.rbt_masculino.Text = "Masculino ";
            this.rbt_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(577, 157);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(163, 71);
            this.txt_direccion.TabIndex = 15;
            this.txt_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nacimiento
            // 
            this.txt_nacimiento.Location = new System.Drawing.Point(577, 123);
            this.txt_nacimiento.MaxLength = 4;
            this.txt_nacimiento.Name = "txt_nacimiento";
            this.txt_nacimiento.Size = new System.Drawing.Size(163, 20);
            this.txt_nacimiento.TabIndex = 14;
            this.txt_nacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeros_KeyPress);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(434, 156);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(77, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Direccion:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(433, 123);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(142, 19);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Año de Nacimiento:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(231, 232);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(192, 20);
            this.txt_telefono.TabIndex = 7;
            this.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeros_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(113, 233);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 35;
            this.materialLabel4.Text = "Telefono:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(231, 123);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(192, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_letras_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(106, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Nombre:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(81, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 30;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(571, 381);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(169, 35);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar valores";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // ConsultaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 519);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txt_apem);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.txt_apep);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.rbt_femenino);
            this.Controls.Add(this.rbt_masculino);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nacimiento);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmb_correos);
            this.Controls.Add(this.btn_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaIndividual";
            this.Text = "ConsultaIndividual";
            this.Load += new System.EventHandler(this.ConsultaIndividual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cmb_correos;
        private System.Windows.Forms.TextBox txt_apem;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.TextBox txt_apep;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_alergias;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.RadioButton rbt_femenino;
        private System.Windows.Forms.RadioButton rbt_masculino;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nacimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox txt_telefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txt_nombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btn_modificar;
    }
}