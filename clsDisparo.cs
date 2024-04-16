using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGrabarFirma
{
    internal class clsDisparo
    {
        public PictureBox imgDisparo { get; set; }
        public int Velocidad { get; set; }

        //Propiedad del disparo
        public clsDisparo()
        {
            //Configuro y le doy imagen, tamaño, etc al disparo
            imgDisparo = new PictureBox();
            imgDisparo.SizeMode = PictureBoxSizeMode.Zoom;
            imgDisparo.BackColor = Color.Transparent;
            imgDisparo.ImageLocation = "https://art.pixilart.com/7461ad7c27b46fa.png";
            Velocidad = 10; // Velocidad del disparo (puedes ajustar según sea necesario)
        }
    }
}
