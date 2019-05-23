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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_respuesta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_recuperar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_pregunta = new System.Windows.Forms.Label();
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
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
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
            // 
            // RecuperaContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(364, 379);
            this.Controls.Add(this.lbl_pregunta);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_correo);
            this.Name = "RecuperaContra";
            this.Text = "Recuperar contraseña";
            this.Load += new System.EventHandler(this.RecuperaContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_respuesta;
        private MaterialSkin.Controls.MaterialFlatButton btn_recuperar;
        private System.Windows.Forms.Label lbl_pregunta;
    }
}