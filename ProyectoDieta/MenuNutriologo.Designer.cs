﻿namespace ProyectoDieta
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
            this.gatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(240, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 36);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perrosToolStripMenuItem,
            this.gatosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // perrosToolStripMenuItem
            // 
            this.perrosToolStripMenuItem.Name = "perrosToolStripMenuItem";
            this.perrosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.perrosToolStripMenuItem.Text = "Paciente Nuevo";
            this.perrosToolStripMenuItem.Click += new System.EventHandler(this.perrosToolStripMenuItem_Click);
            // 
            // gatosToolStripMenuItem
            // 
            this.gatosToolStripMenuItem.Name = "gatosToolStripMenuItem";
            this.gatosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gatosToolStripMenuItem.Text = "Alimentos";
            this.gatosToolStripMenuItem.Click += new System.EventHandler(this.gatosToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(27, 106);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(815, 486);
            this.panelContainer.TabIndex = 1;
            // 
            // MenuNutriologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 604);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "MenuNutriologo";
            this.Text = "MenuNutriologo";
            this.Load += new System.EventHandler(this.MenuNutriologo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatosToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;

    }
}