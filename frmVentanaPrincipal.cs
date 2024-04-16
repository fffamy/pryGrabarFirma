using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGrabarFirma
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void grabarFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrabarFirma v = new frmGrabarFirma();
            v.ShowDialog();
        }

        private void galagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGalaga v = new frmGalaga();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Puedes mostrar un mensaje de confirmación si deseas preguntar al usuario si realmente desea salir
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario hace clic en "Sí", cierra la aplicación
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
