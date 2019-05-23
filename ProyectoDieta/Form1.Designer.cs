namespace ProyectoDieta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_pws = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_recuperar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Hint = "Correo electrónico";
            this.txt_correo.Location = new System.Drawing.Point(111, 134);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(200, 23);
            this.txt_correo.TabIndex = 0;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // txt_pws
            // 
            this.txt_pws.Depth = 0;
            this.txt_pws.Hint = "Contraseña";
            this.txt_pws.Location = new System.Drawing.Point(111, 184);
            this.txt_pws.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pws.Name = "txt_pws";
            this.txt_pws.PasswordChar = '*';
            this.txt_pws.SelectedText = "";
            this.txt_pws.SelectionLength = 0;
            this.txt_pws.SelectionStart = 0;
            this.txt_pws.Size = new System.Drawing.Size(200, 23);
            this.txt_pws.TabIndex = 1;
            this.txt_pws.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(111, 239);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MaximumSize = new System.Drawing.Size(100, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(77, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Ingresar ";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.AutoSize = true;
            this.btn_recuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuperar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_recuperar.Depth = 0;
            this.btn_recuperar.Location = new System.Drawing.Point(222, 239);
            this.btn_recuperar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_recuperar.MaximumSize = new System.Drawing.Size(100, 36);
            this.btn_recuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Primary = false;
            this.btn_recuperar.Size = new System.Drawing.Size(89, 36);
            this.btn_recuperar.TabIndex = 3;
            this.btn_recuperar.Text = "Recuperar";
            this.btn_recuperar.UseVisualStyleBackColor = false;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 417);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_pws);
            this.Controls.Add(this.txt_correo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_pws;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btn_recuperar;

    }
}

