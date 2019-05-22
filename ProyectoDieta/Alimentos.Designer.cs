<<<<<<< HEAD
﻿namespace ProyectoDieta
{
    partial class form
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_comida = new System.Windows.Forms.TextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.list_frutas = new System.Windows.Forms.ListBox();
            this.list_leguminosas = new System.Windows.Forms.ListBox();
            this.list_cereales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(70, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Frutas y verduras";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(613, 41);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(119, 28);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_comida
            // 
            this.txt_comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comida.Location = new System.Drawing.Point(32, 43);
            this.txt_comida.Name = "txt_comida";
            this.txt_comida.Size = new System.Drawing.Size(231, 26);
            this.txt_comida.TabIndex = 26;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "--Selecciona una Categoria --",
            "Frutas y verduras",
            "Lugiminosas y alimentos de origen animal",
            "Cerales"});
            this.cmb_categoria.Location = new System.Drawing.Point(295, 41);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(267, 28);
            this.cmb_categoria.TabIndex = 27;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(304, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 38);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Lugiminosas y alimentos\r\nde origen animal";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(620, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Cereales";
            // 
            // list_frutas
            // 
            this.list_frutas.BackColor = System.Drawing.Color.Silver;
            this.list_frutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_frutas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_frutas.FormattingEnabled = true;
            this.list_frutas.ItemHeight = 18;
            this.list_frutas.Location = new System.Drawing.Point(32, 136);
            this.list_frutas.Name = "list_frutas";
            this.list_frutas.Size = new System.Drawing.Size(195, 326);
            this.list_frutas.TabIndex = 30;
            // 
            // list_leguminosas
            // 
            this.list_leguminosas.BackColor = System.Drawing.Color.Silver;
            this.list_leguminosas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_leguminosas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_leguminosas.FormattingEnabled = true;
            this.list_leguminosas.ItemHeight = 18;
            this.list_leguminosas.Location = new System.Drawing.Point(295, 136);
            this.list_leguminosas.Name = "list_leguminosas";
            this.list_leguminosas.Size = new System.Drawing.Size(195, 326);
            this.list_leguminosas.TabIndex = 31;
            // 
            // list_cereales
            // 
            this.list_cereales.BackColor = System.Drawing.Color.Silver;
            this.list_cereales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_cereales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_cereales.FormattingEnabled = true;
            this.list_cereales.ItemHeight = 18;
            this.list_cereales.Location = new System.Drawing.Point(553, 136);
            this.list_cereales.Name = "list_cereales";
            this.list_cereales.Size = new System.Drawing.Size(195, 326);
            this.list_cereales.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ingrese el alimento a Registrar";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_cereales);
            this.Controls.Add(this.list_leguminosas);
            this.Controls.Add(this.list_frutas);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.txt_comida);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form";
            this.Text = "Alimentos";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_comida;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox list_frutas;
        private System.Windows.Forms.ListBox list_leguminosas;
        private System.Windows.Forms.ListBox list_cereales;
        private System.Windows.Forms.Label label1;
    }
=======
﻿namespace ProyectoDieta
{
    partial class form
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_comida = new System.Windows.Forms.TextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.list_frutas = new System.Windows.Forms.ListBox();
            this.list_leguminosas = new System.Windows.Forms.ListBox();
            this.list_cereales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(70, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Frutas y verduras";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(613, 41);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(119, 28);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_comida
            // 
            this.txt_comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comida.Location = new System.Drawing.Point(32, 43);
            this.txt_comida.Name = "txt_comida";
            this.txt_comida.Size = new System.Drawing.Size(231, 26);
            this.txt_comida.TabIndex = 26;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "--Selecciona una Categoria --",
            "Frutas y verduras",
            "Lugiminosas y alimentos de origen animal",
            "Cerales"});
            this.cmb_categoria.Location = new System.Drawing.Point(295, 41);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(267, 28);
            this.cmb_categoria.TabIndex = 27;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(304, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 38);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Lugiminosas y alimentos\r\nde origen animal";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(620, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Cereales";
            // 
            // list_frutas
            // 
            this.list_frutas.BackColor = System.Drawing.Color.Silver;
            this.list_frutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_frutas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_frutas.FormattingEnabled = true;
            this.list_frutas.ItemHeight = 18;
            this.list_frutas.Location = new System.Drawing.Point(32, 136);
            this.list_frutas.Name = "list_frutas";
            this.list_frutas.Size = new System.Drawing.Size(195, 326);
            this.list_frutas.TabIndex = 30;
            // 
            // list_leguminosas
            // 
            this.list_leguminosas.BackColor = System.Drawing.Color.Silver;
            this.list_leguminosas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_leguminosas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_leguminosas.FormattingEnabled = true;
            this.list_leguminosas.ItemHeight = 18;
            this.list_leguminosas.Location = new System.Drawing.Point(295, 136);
            this.list_leguminosas.Name = "list_leguminosas";
            this.list_leguminosas.Size = new System.Drawing.Size(195, 326);
            this.list_leguminosas.TabIndex = 31;
            // 
            // list_cereales
            // 
            this.list_cereales.BackColor = System.Drawing.Color.Silver;
            this.list_cereales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_cereales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_cereales.FormattingEnabled = true;
            this.list_cereales.ItemHeight = 18;
            this.list_cereales.Location = new System.Drawing.Point(553, 136);
            this.list_cereales.Name = "list_cereales";
            this.list_cereales.Size = new System.Drawing.Size(195, 326);
            this.list_cereales.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ingrese el alimento a Registrar";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_cereales);
            this.Controls.Add(this.list_leguminosas);
            this.Controls.Add(this.list_frutas);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.txt_comida);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form";
            this.Text = "Alimentos";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_comida;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox list_frutas;
        private System.Windows.Forms.ListBox list_leguminosas;
        private System.Windows.Forms.ListBox list_cereales;
        private System.Windows.Forms.Label label1;
    }
>>>>>>> 82655591fb6cd62a39820d2089d562b892634941
}