namespace ProyectoDieta
{
    partial class MenuNutriologo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
>>>>>>> c9059d58486e9e5c4984d9726c76329bb5312c88
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(27, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 36);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perrosToolStripMenuItem,
            this.gatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pacientesToolStripMenuItem.Text = "Menu";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(27, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(815, 486);
            this.panelContainer.TabIndex = 1;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.x;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // perrosToolStripMenuItem
            // 
            this.perrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteNuevoToolStripMenuItem,
            this.bajaPacienteToolStripMenuItem,
            this.pacienteModificarToolStripMenuItem,
            this.consultasIndividualToolStripMenuItem});
            this.perrosToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.pa;
            this.perrosToolStripMenuItem.Name = "perrosToolStripMenuItem";
            this.perrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perrosToolStripMenuItem.Text = "Paciente";
            this.perrosToolStripMenuItem.Click += new System.EventHandler(this.perrosToolStripMenuItem_Click);
            // 
            // pacienteNuevoToolStripMenuItem
            // 
            this.pacienteNuevoToolStripMenuItem.Name = "pacienteNuevoToolStripMenuItem";
            this.pacienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pacienteNuevoToolStripMenuItem.Text = "Paciente Nuevo";
            this.pacienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.pacienteNuevoToolStripMenuItem_Click);
            // 
            // bajaPacienteToolStripMenuItem
            // 
            this.bajaPacienteToolStripMenuItem.Name = "bajaPacienteToolStripMenuItem";
            this.bajaPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bajaPacienteToolStripMenuItem.Text = "Baja Paciente";
            // 
            // pacienteModificarToolStripMenuItem
            // 
            this.pacienteModificarToolStripMenuItem.Name = "pacienteModificarToolStripMenuItem";
            this.pacienteModificarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pacienteModificarToolStripMenuItem.Text = "Paciente Modificar";
            // 
            // consultasIndividualToolStripMenuItem
            // 
            this.consultasIndividualToolStripMenuItem.Name = "consultasIndividualToolStripMenuItem";
            this.consultasIndividualToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultasIndividualToolStripMenuItem.Text = "Consultar Paciente";
            this.consultasIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultasIndividualToolStripMenuItem_Click);
            // 
            // gatosToolStripMenuItem
            // 
            this.gatosToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.alimentos;
            this.gatosToolStripMenuItem.Name = "gatosToolStripMenuItem";
            this.gatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gatosToolStripMenuItem.Text = "Alimentos";
            this.gatosToolStripMenuItem.Click += new System.EventHandler(this.gatosToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
=======
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(27, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(815, 486);
            this.panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDieta.Properties.Resources._42789722_310615923092565_9096491333760246080_n1;
            this.pictureBox1.Location = new System.Drawing.Point(72, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
>>>>>>> c9059d58486e9e5c4984d9726c76329bb5312c88
            // MenuNutriologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 604);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MenuNutriologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNutriologo";
            this.Load += new System.EventHandler(this.MenuNutriologo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatosToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem consultasIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
=======
        private System.Windows.Forms.PictureBox pictureBox1;
>>>>>>> c9059d58486e9e5c4984d9726c76329bb5312c88

    }
}