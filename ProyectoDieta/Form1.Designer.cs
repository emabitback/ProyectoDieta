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
            this.txt_nombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_contrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Depth = 0;
            this.txt_nombreUsuario.Hint = "Nombre de Usuario";
            this.txt_nombreUsuario.Location = new System.Drawing.Point(109, 153);
            this.txt_nombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.PasswordChar = '\0';
            this.txt_nombreUsuario.SelectedText = "";
            this.txt_nombreUsuario.SelectionLength = 0;
            this.txt_nombreUsuario.SelectionStart = 0;
            this.txt_nombreUsuario.Size = new System.Drawing.Size(186, 23);
            this.txt_nombreUsuario.TabIndex = 0;
            this.txt_nombreUsuario.UseSystemPasswordChar = false;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Depth = 0;
            this.txt_contrasena.Hint = "Contraseña";
            this.txt_contrasena.Location = new System.Drawing.Point(109, 203);
            this.txt_contrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '\0';
            this.txt_contrasena.SelectedText = "";
            this.txt_contrasena.SelectionLength = 0;
            this.txt_contrasena.SelectionStart = 0;
            this.txt_contrasena.Size = new System.Drawing.Size(186, 23);
            this.txt_contrasena.TabIndex = 1;
            this.txt_contrasena.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(218, 255);
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(123, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(151, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 426);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombreUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_contrasena;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

