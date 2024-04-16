namespace pryGrabarFirma
{
    partial class frmGalaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalaga));
            SuspendLayout();
            // 
            // frmGalaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(780, 757);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmGalaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGalaga";
            Load += frmGalaga_Load;
            KeyDown += frmGalaga_KeyDown;
            ResumeLayout(false);
        }

        #endregion
    }
}