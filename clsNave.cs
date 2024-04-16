using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGrabarFirma
{
    internal class clsNave
    {
        //Propiedades
        public string nombre;
        public int vida;
        int puntosDaño;
        public PictureBox imgNave;

        public void crearJugador()
        {
            vida = 100;
            nombre = "jugador1";
            puntosDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.Zoom;
            imgNave.BackColor = Color.Transparent;
            imgNave.ImageLocation = "https://www.pngall.com/wp-content/uploads/13/Space-Invaders-Ship-PNG-Photo.png";

        }

        public void crearEnemigo()
        {
            vida = 25;
            nombre = "malito1";
            puntosDaño= 2;
        }

    }
}
