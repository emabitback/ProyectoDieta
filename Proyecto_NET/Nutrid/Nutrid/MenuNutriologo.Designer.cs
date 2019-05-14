namespace Nutrid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAlimenticioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPaciente1 = new Nutrid.RegistrarPaciente();
            this.consultaIndividual1 = new Nutrid.ConsultaIndividual();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.alimentosToolStripMenuItem,
            this.planAlimenticioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultaIndividualToolStripMenuItem,
            this.consultarTodosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.DropDownClosed += new System.EventHandler(this.pacientesToolStripMenuItem_DropDownClosed);
            this.pacientesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.pacientesToolStripMenuItem_DropDownOpened);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultaIndividualToolStripMenuItem
            // 
            this.consultaIndividualToolStripMenuItem.Name = "consultaIndividualToolStripMenuItem";
            this.consultaIndividualToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.consultaIndividualToolStripMenuItem.Text = "Consulta individual";
            this.consultaIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultaIndividualToolStripMenuItem_Click);
            // 
            // consultarTodosToolStripMenuItem
            // 
            this.consultarTodosToolStripMenuItem.Name = "consultarTodosToolStripMenuItem";
            this.consultarTodosToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.consultarTodosToolStripMenuItem.Text = "Consultar todos";
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alimentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            // 
            // planAlimenticioToolStripMenuItem
            // 
            this.planAlimenticioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planAlimenticioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.planAlimenticioToolStripMenuItem.Name = "planAlimenticioToolStripMenuItem";
            this.planAlimenticioToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.planAlimenticioToolStripMenuItem.Text = "Plan alimenticio";
            // 
            // registrarPaciente1
            // 
            this.registrarPaciente1.BackColor = System.Drawing.Color.White;
            this.registrarPaciente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrarPaciente1.Location = new System.Drawing.Point(0, 29);
            this.registrarPaciente1.Name = "registrarPaciente1";
            this.registrarPaciente1.Size = new System.Drawing.Size(975, 527);
            this.registrarPaciente1.TabIndex = 1;
            // 
            // consultaIndividual1
            // 
            this.consultaIndividual1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultaIndividual1.Location = new System.Drawing.Point(0, 29);
            this.consultaIndividual1.Name = "consultaIndividual1";
            this.consultaIndividual1.Size = new System.Drawing.Size(975, 527);
            this.consultaIndividual1.TabIndex = 2;
            // 
            // MenuNutriologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 556);
            this.Controls.Add(this.consultaIndividual1);
            this.Controls.Add(this.registrarPaciente1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuNutriologo";
            this.Text = "MenuNutriologo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planAlimenticioToolStripMenuItem;
        private RegistrarPaciente registrarPaciente1;
        private ConsultaIndividual consultaIndividual1;
    }
}