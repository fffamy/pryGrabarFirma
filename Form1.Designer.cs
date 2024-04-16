namespace pryGrabarFirma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbFirma = new PictureBox();
            pbFirma2 = new PictureBox();
            btnDibujar = new Button();
            btnGrabarFirma = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFirma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFirma2).BeginInit();
            SuspendLayout();
            // 
            // pbFirma
            // 
            pbFirma.BorderStyle = BorderStyle.FixedSingle;
            pbFirma.Location = new Point(104, 68);
            pbFirma.Name = "pbFirma";
            pbFirma.Size = new Size(360, 326);
            pbFirma.TabIndex = 0;
            pbFirma.TabStop = false;
            // 
            // pbFirma2
            // 
            pbFirma2.BorderStyle = BorderStyle.FixedSingle;
            pbFirma2.Location = new Point(599, 68);
            pbFirma2.Name = "pbFirma2";
            pbFirma2.Size = new Size(360, 326);
            pbFirma2.SizeMode = PictureBoxSizeMode.AutoSize;
            pbFirma2.TabIndex = 1;
            pbFirma2.TabStop = false;
            pbFirma2.MouseDown += pbFirma2_MouseDown;
            pbFirma2.MouseMove += pbFirma2_MouseMove;
            pbFirma2.MouseUp += pbFirma2_MouseUp;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(104, 426);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(106, 72);
            btnDibujar.TabIndex = 2;
            btnDibujar.Text = "Dibujar";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // btnGrabarFirma
            // 
            btnGrabarFirma.Location = new Point(853, 426);
            btnGrabarFirma.Name = "btnGrabarFirma";
            btnGrabarFirma.Size = new Size(106, 72);
            btnGrabarFirma.TabIndex = 3;
            btnGrabarFirma.Text = "Grabar";
            btnGrabarFirma.UseVisualStyleBackColor = true;
            btnGrabarFirma.Click += btnGrabarFirma_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(479, 426);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 72);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1058, 556);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabarFirma);
            Controls.Add(btnDibujar);
            Controls.Add(pbFirma2);
            Controls.Add(pbFirma);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grabar Firma";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbFirma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFirma2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFirma;
        private PictureBox pbFirma2;
        private Button btnDibujar;
        private Button btnGrabarFirma;
        private Button btnBorrar;
    }
}
