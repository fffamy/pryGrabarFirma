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
    public partial class frmGalaga : Form
    {
        //Declaraciones Globales
        clsNave objNaveJugador;

        public frmGalaga()
        {
            InitializeComponent();
        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.crearJugador();
            Controls.Add(objNaveJugador.imgNave);
        }
    }
}
