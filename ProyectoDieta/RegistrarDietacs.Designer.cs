namespace ProyectoDieta
{
    partial class RegistrarDietacs
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
            this.cmb_correos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_alimento = new System.Windows.Forms.ComboBox();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cmb_correos.Location = new System.Drawing.Point(57, 25);
            this.cmb_correos.Name = "cmb_correos";
            this.cmb_correos.Size = new System.Drawing.Size(180, 28);
            this.cmb_correos.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Elegir correo";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "frutas",
            "leguminosas",
            "cereales"});
            this.cmb_categoria.Location = new System.Drawing.Point(280, 145);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(180, 28);
            this.cmb_categoria.TabIndex = 37;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Día";
            // 
            // cmb_dia
            // 
            this.cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cmb_dia.Location = new System.Drawing.Point(62, 146);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(180, 28);
            this.cmb_dia.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Alimento";
            // 
            // cmb_alimento
            // 
            this.cmb_alimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_alimento.FormattingEnabled = true;
            this.cmb_alimento.Items.AddRange(new object[] {
            "--Selecciona una Categoria --",
            "Frutas y verduras",
            "Lugiminosas y alimentos de origen animal",
            "Cerales"});
            this.cmb_alimento.Location = new System.Drawing.Point(62, 256);
            this.cmb_alimento.Name = "cmb_alimento";
            this.cmb_alimento.Size = new System.Drawing.Size(180, 28);
            this.cmb_alimento.TabIndex = 41;
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_asignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar.ForeColor = System.Drawing.Color.White;
            this.btn_asignar.Location = new System.Drawing.Point(280, 252);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(180, 35);
            this.btn_asignar.TabIndex = 43;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = false;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // RegistrarDietacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 490);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_alimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_dia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_correos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarDietacs";
            this.Text = "RegistrarDietacs";
            this.Load += new System.EventHandler(this.RegistrarDietacs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_correos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_alimento;
        private System.Windows.Forms.Button btn_asignar;
    }
}