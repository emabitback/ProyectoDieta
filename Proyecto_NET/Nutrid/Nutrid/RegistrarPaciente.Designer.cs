namespace Nutrid
{
    partial class RegistrarPaciente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apep = new System.Windows.Forms.TextBox();
            this.txt_apem = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nacimiento = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_masculino = new System.Windows.Forms.RadioButton();
            this.rtb_femenino = new System.Windows.Forms.RadioButton();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_pregunta = new System.Windows.Forms.ComboBox();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_alergias = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Gray;
            this.txt_correo.Location = new System.Drawing.Point(58, 66);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(204, 29);
            this.txt_correo.TabIndex = 0;
            this.txt_correo.Text = "Correo electrónico";
            this.txt_correo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_correo_MouseClick);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Gray;
            this.txt_nombre.Location = new System.Drawing.Point(58, 175);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(204, 29);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_nombre_MouseClick);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_apep
            // 
            this.txt_apep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apep.ForeColor = System.Drawing.Color.Gray;
            this.txt_apep.Location = new System.Drawing.Point(58, 227);
            this.txt_apep.Name = "txt_apep";
            this.txt_apep.Size = new System.Drawing.Size(204, 29);
            this.txt_apep.TabIndex = 2;
            this.txt_apep.Text = "Apellido paterno";
            this.txt_apep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_apep_MouseClick);
            this.txt_apep.Leave += new System.EventHandler(this.txt_apep_Leave);
            // 
            // txt_apem
            // 
            this.txt_apem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apem.ForeColor = System.Drawing.Color.Gray;
            this.txt_apem.Location = new System.Drawing.Point(58, 277);
            this.txt_apem.Name = "txt_apem";
            this.txt_apem.Size = new System.Drawing.Size(204, 29);
            this.txt_apem.TabIndex = 3;
            this.txt_apem.Text = "Apellido materno";
            this.txt_apem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_apem_MouseClick);
            this.txt_apem.Leave += new System.EventHandler(this.txt_apem_Leave);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Gray;
            this.txt_telefono.Location = new System.Drawing.Point(58, 329);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(204, 29);
            this.txt_telefono.TabIndex = 4;
            this.txt_telefono.Text = "Teléfono";
            this.txt_telefono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_telefono_MouseClick);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // txt_nacimiento
            // 
            this.txt_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nacimiento.ForeColor = System.Drawing.Color.Gray;
            this.txt_nacimiento.Location = new System.Drawing.Point(58, 379);
            this.txt_nacimiento.Name = "txt_nacimiento";
            this.txt_nacimiento.Size = new System.Drawing.Size(204, 29);
            this.txt_nacimiento.TabIndex = 5;
            this.txt_nacimiento.Text = "Año de nacimiento";
            this.txt_nacimiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_nacimiento_MouseClick);
            this.txt_nacimiento.Leave += new System.EventHandler(this.txt_nacimiento_Leave);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Gray;
            this.txt_direccion.Location = new System.Drawing.Point(293, 66);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(204, 29);
            this.txt_direccion.TabIndex = 6;
            this.txt_direccion.Text = "Dirección";
            this.txt_direccion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_direccion_MouseClick);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(290, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sexo";
            // 
            // rbt_masculino
            // 
            this.rbt_masculino.AutoSize = true;
            this.rbt_masculino.Checked = true;
            this.rbt_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_masculino.ForeColor = System.Drawing.Color.Gray;
            this.rbt_masculino.Location = new System.Drawing.Point(413, 121);
            this.rbt_masculino.Name = "rbt_masculino";
            this.rbt_masculino.Size = new System.Drawing.Size(84, 24);
            this.rbt_masculino.TabIndex = 8;
            this.rbt_masculino.TabStop = true;
            this.rbt_masculino.Text = "Hombre";
            this.rbt_masculino.UseVisualStyleBackColor = true;
            // 
            // rtb_femenino
            // 
            this.rtb_femenino.AutoSize = true;
            this.rtb_femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_femenino.ForeColor = System.Drawing.Color.Gray;
            this.rtb_femenino.Location = new System.Drawing.Point(413, 172);
            this.rtb_femenino.Name = "rtb_femenino";
            this.rtb_femenino.Size = new System.Drawing.Size(66, 24);
            this.rtb_femenino.TabIndex = 9;
            this.rtb_femenino.TabStop = true;
            this.rtb_femenino.Text = "Mujer";
            this.rtb_femenino.UseVisualStyleBackColor = true;
            // 
            // txt_psw
            // 
            this.txt_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_psw.ForeColor = System.Drawing.Color.Gray;
            this.txt_psw.Location = new System.Drawing.Point(58, 120);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(204, 29);
            this.txt_psw.TabIndex = 10;
            this.txt_psw.Text = "Contraseña";
            this.txt_psw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_psw_MouseClick);
            this.txt_psw.Leave += new System.EventHandler(this.txt_psw_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(290, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pregunta de recuperación";
            // 
            // cmb_pregunta
            // 
            this.cmb_pregunta.BackColor = System.Drawing.Color.White;
            this.cmb_pregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pregunta.ForeColor = System.Drawing.Color.Gray;
            this.cmb_pregunta.FormattingEnabled = true;
            this.cmb_pregunta.Items.AddRange(new object[] {
            "¿Cuál fue tu primer número?",
            "¿Nombre de tu mascota?",
            "Comida favorita"});
            this.cmb_pregunta.Location = new System.Drawing.Point(293, 275);
            this.cmb_pregunta.Name = "cmb_pregunta";
            this.cmb_pregunta.Size = new System.Drawing.Size(204, 28);
            this.cmb_pregunta.TabIndex = 12;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.ForeColor = System.Drawing.Color.Gray;
            this.txt_respuesta.Location = new System.Drawing.Point(293, 329);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(204, 29);
            this.txt_respuesta.TabIndex = 13;
            this.txt_respuesta.Text = "Respuesta";
            this.txt_respuesta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_respuesta_MouseClick);
            this.txt_respuesta.Leave += new System.EventHandler(this.txt_respuesta_Leave);
            // 
            // txt_peso
            // 
            this.txt_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_peso.ForeColor = System.Drawing.Color.Gray;
            this.txt_peso.Location = new System.Drawing.Point(538, 66);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(204, 29);
            this.txt_peso.TabIndex = 14;
            this.txt_peso.Text = "Peso";
            this.txt_peso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_peso_MouseClick);
            this.txt_peso.Leave += new System.EventHandler(this.txt_peso_Leave);
            // 
            // txt_altura
            // 
            this.txt_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_altura.ForeColor = System.Drawing.Color.Gray;
            this.txt_altura.Location = new System.Drawing.Point(538, 121);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(204, 29);
            this.txt_altura.TabIndex = 15;
            this.txt_altura.Text = "Altura";
            this.txt_altura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_altura_MouseClick);
            this.txt_altura.Leave += new System.EventHandler(this.txt_altura_Leave);
            // 
            // txt_alergias
            // 
            this.txt_alergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alergias.ForeColor = System.Drawing.Color.Gray;
            this.txt_alergias.Location = new System.Drawing.Point(538, 223);
            this.txt_alergias.Multiline = true;
            this.txt_alergias.Name = "txt_alergias";
            this.txt_alergias.Size = new System.Drawing.Size(204, 135);
            this.txt_alergias.TabIndex = 16;
            this.txt_alergias.Text = "Alergias";
            this.txt_alergias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_alergias_MouseClick);
            this.txt_alergias.Leave += new System.EventHandler(this.txt_alergias_Leave);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(538, 379);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(204, 29);
            this.btn_registrar.TabIndex = 17;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // RegistrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_alergias);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.cmb_pregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.rtb_femenino);
            this.Controls.Add(this.rbt_masculino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nacimiento);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_apem);
            this.Controls.Add(this.txt_apep);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_correo);
            this.Name = "RegistrarPaciente";
            this.Size = new System.Drawing.Size(788, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apep;
        private System.Windows.Forms.TextBox txt_apem;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nacimiento;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_masculino;
        private System.Windows.Forms.RadioButton rtb_femenino;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_pregunta;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_alergias;
        private System.Windows.Forms.Button btn_registrar;

    }
}
