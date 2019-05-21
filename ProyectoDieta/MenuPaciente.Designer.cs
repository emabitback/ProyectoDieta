namespace ProyectoDieta
{
    partial class MenuPaciente
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
            this.miDietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ImagenFondo = new System.Windows.Forms.PictureBox();
            this.encabezado = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).BeginInit();
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
            this.miDietaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miDietaToolStripMenuItem
            // 
            this.miDietaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.miDietaToolStripMenuItem.Name = "miDietaToolStripMenuItem";
            this.miDietaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.miDietaToolStripMenuItem.Text = "Mi Dieta";
            // 
            // miPToolStripMenuItem
            // 
            this.miPToolStripMenuItem.Name = "miPToolStripMenuItem";
            this.miPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.miPToolStripMenuItem.Text = "Mi Plan";
            this.miPToolStripMenuItem.Click += new System.EventHandler(this.miPToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.encabezado);
            this.panelContainer.Controls.Add(this.ImagenFondo);
            this.panelContainer.Location = new System.Drawing.Point(27, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(815, 486);
            this.panelContainer.TabIndex = 1;
            // 
            // ImagenFondo
            // 
            this.ImagenFondo.Image = global::ProyectoDieta.Properties.Resources.consejo;
            this.ImagenFondo.Location = new System.Drawing.Point(135, 78);
            this.ImagenFondo.Name = "ImagenFondo";
            this.ImagenFondo.Size = new System.Drawing.Size(559, 351);
            this.ImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFondo.TabIndex = 0;
            this.ImagenFondo.TabStop = false;
            this.ImagenFondo.Visible = false;
            // 
            // encabezado
            // 
            this.encabezado.AutoSize = true;
            this.encabezado.Depth = 0;
            this.encabezado.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encabezado.Location = new System.Drawing.Point(311, 22);
            this.encabezado.MouseState = MaterialSkin.MouseState.HOVER;
            this.encabezado.Name = "encabezado";
            this.encabezado.Size = new System.Drawing.Size(145, 40);
            this.encabezado.TabIndex = 1;
            this.encabezado.Text = "Consejos";
            // 
            // MenuPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 604);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPaciente";
            this.Load += new System.EventHandler(this.MenuPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miDietaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox ImagenFondo;
        private MaterialSkin.Controls.MaterialLabel encabezado;
    }
}