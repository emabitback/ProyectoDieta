namespace ProyectoDieta
{
    partial class RecuperaContra
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.txt_respuesta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_recuperar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_pregunta = new System.Windows.Forms.Label();
=======
            this.cmb_correos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(82, 80);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MaximumSize = new System.Drawing.Size(100, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Buscar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
=======
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Hint = "Correo electrónico";
            this.txt_correo.Location = new System.Drawing.Point(82, 38);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(200, 23);
            this.txt_correo.TabIndex = 3;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
<<<<<<< HEAD
=======
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
            this.cmb_correos.Location = new System.Drawing.Point(82, 145);
            this.cmb_correos.Name = "cmb_correos";
            this.cmb_correos.Size = new System.Drawing.Size(200, 28);
            this.cmb_correos.TabIndex = 29;
            // 
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pregunta";
            // 
<<<<<<< HEAD
            // txt_respuesta
            // 
            this.txt_respuesta.Depth = 0;
            this.txt_respuesta.Hint = "Respuesta";
            this.txt_respuesta.Location = new System.Drawing.Point(82, 201);
            this.txt_respuesta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.PasswordChar = '\0';
            this.txt_respuesta.SelectedText = "";
            this.txt_respuesta.SelectionLength = 0;
            this.txt_respuesta.SelectionStart = 0;
            this.txt_respuesta.Size = new System.Drawing.Size(200, 23);
            this.txt_respuesta.TabIndex = 31;
            this.txt_respuesta.UseSystemPasswordChar = false;
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.AutoSize = true;
            this.btn_recuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuperar.Depth = 0;
            this.btn_recuperar.Location = new System.Drawing.Point(82, 248);
            this.btn_recuperar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_recuperar.MaximumSize = new System.Drawing.Size(100, 36);
            this.btn_recuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Primary = false;
            this.btn_recuperar.Size = new System.Drawing.Size(89, 36);
            this.btn_recuperar.TabIndex = 32;
            this.btn_recuperar.Text = "Recuperar";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pregunta.Location = new System.Drawing.Point(79, 157);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(18, 20);
            this.lbl_pregunta.TabIndex = 33;
            this.lbl_pregunta.Text = "_";
=======
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Respuesta";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(82, 201);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextField1.TabIndex = 31;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(82, 248);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MaximumSize = new System.Drawing.Size(100, 36);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton2.TabIndex = 32;
            this.materialFlatButton2.Text = "Recuperar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            // 
            // RecuperaContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(364, 379);
<<<<<<< HEAD
            this.Controls.Add(this.lbl_pregunta);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label1);
=======
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_correos);
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_correo);
            this.Name = "RecuperaContra";
            this.Text = "Recuperar contraseña";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.RecuperaContra_Load);
=======
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
<<<<<<< HEAD
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_respuesta;
        private MaterialSkin.Controls.MaterialFlatButton btn_recuperar;
        private System.Windows.Forms.Label lbl_pregunta;
=======
        private System.Windows.Forms.ComboBox cmb_correos;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
>>>>>>> 65e950c64ff1958f1166e20f11d42b32b82d3629
    }
}