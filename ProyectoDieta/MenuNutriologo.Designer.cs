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
            this.perrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAlimenticioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pacientesToolStripMenuItem,
            this.alimentosToolStripMenuItem,
            this.planAlimenticioToolStripMenuItem});
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
            this.consultaIndividualToolStripMenuItem,
            this.gatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // perrosToolStripMenuItem
            // 
            this.perrosToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.pa;
            this.perrosToolStripMenuItem.Name = "perrosToolStripMenuItem";
            this.perrosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.perrosToolStripMenuItem.Text = "Paciente Nuevo";
            this.perrosToolStripMenuItem.Click += new System.EventHandler(this.perrosToolStripMenuItem_Click);
            // 
            // consultaIndividualToolStripMenuItem
            // 
            this.consultaIndividualToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.consulta;
            this.consultaIndividualToolStripMenuItem.Name = "consultaIndividualToolStripMenuItem";
            this.consultaIndividualToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaIndividualToolStripMenuItem.Text = "Consulta individual";
            this.consultaIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultaIndividualToolStripMenuItem_Click);
            // 
            // gatosToolStripMenuItem
            // 
            this.gatosToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.listado;
            this.gatosToolStripMenuItem.Name = "gatosToolStripMenuItem";
            this.gatosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gatosToolStripMenuItem.Text = "Listado de pacientes";
            this.gatosToolStripMenuItem.Click += new System.EventHandler(this.gatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.x;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.alimentos;
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            this.alimentosToolStripMenuItem.Click += new System.EventHandler(this.alimentosToolStripMenuItem_Click);
            // 
            // planAlimenticioToolStripMenuItem
            // 
            this.planAlimenticioToolStripMenuItem.Image = global::ProyectoDieta.Properties.Resources.plan;
            this.planAlimenticioToolStripMenuItem.Name = "planAlimenticioToolStripMenuItem";
            this.planAlimenticioToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.planAlimenticioToolStripMenuItem.Text = "Plan alimenticio";
            this.planAlimenticioToolStripMenuItem.Click += new System.EventHandler(this.planAlimenticioToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(27, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(860, 542);
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
            // MenuNutriologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 660);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MenuNutriologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Nutriólogo";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planAlimenticioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}