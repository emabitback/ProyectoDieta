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
            this.cmb_correos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
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
            // 
            // RecuperaContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(364, 379);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_correos);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_correo);
            this.Name = "RecuperaContra";
            this.Text = "Recuperar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private System.Windows.Forms.ComboBox cmb_correos;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}