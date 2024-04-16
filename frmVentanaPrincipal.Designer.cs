namespace pryGrabarFirma
{
    partial class frmVentanaPrincipal
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
            menuStrip1 = new MenuStrip();
            lAB3ToolStripMenuItem = new ToolStripMenuItem();
            grabarFirmaToolStripMenuItem = new ToolStripMenuItem();
            galagaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lAB3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lAB3ToolStripMenuItem
            // 
            lAB3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grabarFirmaToolStripMenuItem, galagaToolStripMenuItem, toolStripMenuItem1, salirToolStripMenuItem });
            lAB3ToolStripMenuItem.Name = "lAB3ToolStripMenuItem";
            lAB3ToolStripMenuItem.Size = new Size(46, 20);
            lAB3ToolStripMenuItem.Text = "LAB3";
            // 
            // grabarFirmaToolStripMenuItem
            // 
            grabarFirmaToolStripMenuItem.Name = "grabarFirmaToolStripMenuItem";
            grabarFirmaToolStripMenuItem.Size = new Size(180, 22);
            grabarFirmaToolStripMenuItem.Text = "Grabar Firma";
            grabarFirmaToolStripMenuItem.Click += grabarFirmaToolStripMenuItem_Click;
            // 
            // galagaToolStripMenuItem
            // 
            galagaToolStripMenuItem.Name = "galagaToolStripMenuItem";
            galagaToolStripMenuItem.Size = new Size(180, 22);
            galagaToolStripMenuItem.Text = "Galaga";
            galagaToolStripMenuItem.Click += galagaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frmVentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmVentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lAB3ToolStripMenuItem;
        private ToolStripMenuItem grabarFirmaToolStripMenuItem;
        private ToolStripMenuItem galagaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}