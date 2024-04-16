using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryGrabarFirma
{
    public partial class frmGalaga : Form
    {
        //Declaraciones Globales
        clsNave objNaveJugador;
        private System.Windows.Forms.Timer timerMovimientoEnemigos;
        private System.Windows.Forms.Timer timerDisparos;
        private List<clsDisparo> disparos = new List<clsDisparo>();

        public frmGalaga()
        {
            InitializeComponent();

            timerMovimientoEnemigos = new System.Windows.Forms.Timer();
            timerMovimientoEnemigos.Interval = 100; // Intervalo en milisegundos
            timerMovimientoEnemigos.Tick += TimerMovimientoEnemigos_Tick;
            timerMovimientoEnemigos.Start();

            timerDisparos = new System.Windows.Forms.Timer();
            timerDisparos.Interval = 50; // Ajusta el intervalo según sea necesario
            timerDisparos.Tick += timerDisparos_Tick;
            timerDisparos.Start();

        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(350, 700);

            Controls.Add(objNaveJugador.imgNave);

            // Llamar al método para generar enemigos
            objNaveJugador.generarEnemigos(3); // Generar 3 enemigos al inicio del juego
            foreach (PictureBox enemigo in objNaveJugador.enemigos)
            {
                Controls.Add(enemigo);
            }
        }

        private void ReiniciarJuego()
        {
            // Restablecer la posición de la nave del jugador
            objNaveJugador.imgNave.Location = new Point(350, 700);

            // Eliminar todos los enemigos presentes en el formulario
            foreach (PictureBox enemigo in objNaveJugador.enemigos)
            {
                Controls.Remove(enemigo);
            }
            objNaveJugador.enemigos.Clear();

            // Volver a generar los enemigos
            objNaveJugador.generarEnemigos(3); // Puedes ajustar la cantidad de enemigos según sea necesario
            foreach (PictureBox enemigo in objNaveJugador.enemigos)
            {
                Controls.Add(enemigo);
            }

            // Restablecer cualquier otro estado del juego, como el marcador
            // marcadorPuntaje.Text = "0"; // Si tienes un marcador de puntos, restablecerlo a cero, por ejemplo

            // Reiniciar el temporizador de movimiento de enemigos si es necesario
            timerMovimientoEnemigos.Start(); // Reiniciar el temporizador si se había detenido
        }

        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            // Obtener los límites del formulario
            int limiteIzquierdo = 0;
            int limiteDerecho = ClientSize.Width - objNaveJugador.imgNave.Width;

            // Mover la nave del jugador según las teclas presionadas
            if (e.KeyCode == Keys.Right)
            {
                // Verificar que la nave no se salga del límite derecho
                if (objNaveJugador.imgNave.Location.X < limiteDerecho)
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 10, objNaveJugador.imgNave.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                // Verificar que la nave no se salga del límite izquierdo
                if (objNaveJugador.imgNave.Location.X > limiteIzquierdo)
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 10, objNaveJugador.imgNave.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                clsDisparo disparo = new clsDisparo();
                // Configura la posición inicial del disparo (puedes ajustar según sea necesario)
                disparo.imgDisparo.Location = new Point(objNaveJugador.imgNave.Location.X + objNaveJugador.imgNave.Width / 2, objNaveJugador.imgNave.Location.Y);
                // Agrega el disparo a la lista de disparos
                disparos.Add(disparo);
                // Agrega el PictureBox del disparo al formulario
                Controls.Add(disparo.imgDisparo);
            }
        }

        private void TimerMovimientoEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox enemigo in objNaveJugador.enemigos)
            {
                // Mueve cada enemigo hacia abajo
                enemigo.Top += 10; // Ajusta la velocidad de movimiento según sea necesario
                                   // Verifica si el enemigo ha alcanzado la parte inferior de la pantalla
                if (enemigo.Bottom >= this.ClientSize.Height)
                {
                    // El enemigo ha llegado al fondo, el jugador ha perdido
                    timerMovimientoEnemigos.Stop(); // Detiene el temporizador para evitar que se sigan moviendo los enemigos
                    MessageBox.Show("¡Has perdido!");
                    ReiniciarJuego(); // Método para reiniciar el juego
                    return; // Sal del método para evitar que se sigan moviendo los enemigos después de perder
                }
            }
        }
        private void timerDisparos_Tick(object sender, EventArgs e)
        {
            foreach (clsDisparo disparo in disparos)
            {
                // Mueve el disparo hacia arriba
                disparo.imgDisparo.Top -= disparo.Velocidad;
                // Verifica si el disparo ha salido de la pantalla
                if (disparo.imgDisparo.Bottom <= 0)
                {
                    // Si el disparo está fuera de la pantalla, elimínalo
                    disparos.Remove(disparo);
                    Controls.Remove(disparo.imgDisparo);
                    break; // Sal del bucle para evitar errores de iteración
                }
            }
        }
    }
}
