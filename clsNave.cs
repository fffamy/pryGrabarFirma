using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace pryGrabarFirma
{
    internal class clsNave
    {
        //Propiedades
        public string nombre;
        public int vida;
        int puntosDaño;
        public PictureBox imgNave;
        public List<PictureBox> enemigos;

        //Metodos
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

        public void generarEnemigos(int cantidad)
        {
            enemigos = new List<PictureBox>();

            Random rnd = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                PictureBox enemigo = new PictureBox();
                enemigo.SizeMode = PictureBoxSizeMode.Zoom;
                enemigo.BackColor = Color.Transparent;
                enemigo.ImageLocation = "https://clipground.com/images/space-invader-png-7.png";

                // Posición aleatoria
                int x = rnd.Next(0, 600);
                int y = rnd.Next(0, 200);
                enemigo.Location = new Point(x, y);

                enemigos.Add(enemigo);
            }
        }
    }
}