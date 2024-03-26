namespace pryGrabarFirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pbFirma.CreateGraphics();

            Pen lapicera = new Pen(Color.DarkGreen);

            papel.DrawRectangle(lapicera, 10, 10, 100, 50);
            papel.DrawRectangle(lapicera, 10, 75, 100, 100);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /*Configuro el boton borrar estableciendo la propiedad 'Image' del PictureBox como 'null'
            La propiedad 'Image' del PictureBox representa la imagen que se muestra en el PictureBox, ya sea que la imagen fue
            cargada desde archivos en el sistema, im�genes incrustadas en tu aplicaci�n, o im�genes creadas din�micamente en el tiempo de ejecuci�n.*/
            
            pbFirma.Image = null;
            pbFirma2.Image = null;
        }
        /*Creo la variable booleana 'click' y la inicializo en 'false' para indicar que inicialmente
        no se est� realizando ning�n dibujo en el PictureBox. Cuando el usuario presiona el bot�n del rat�n
        dentro del PictureBox para comenzar a dibujar, se cambia el valor de esta variable a 'true' para indicar
        que se est� llevando a cabo el dibujo.*/

        private bool click = false;

        /*Creo la variable del tipo 'Point' que representa coordenadas en un espacio bidimensional
         en este caso almacena y une el trazo del mouse para hacer el dibujo. */

        private Point coordenadas;

        private void pbFirma2_MouseDown(object sender, MouseEventArgs e)
        {
            //Empiezo a dibujar cuando hago click con el mouse

            click = true;

            //'e.Location' representa las coordenadas (x, y) del rat�n en el control que gener� el evento, en este caso, el PictureBox.
            //Cuando el usuario mueve el rat�n dentro del PictureBox, se activa el evento MouseMove
            //y el par�metro 'e' contiene informaci�n sobre el evento, incluida la ubicaci�n actual del cursor del rat�n.

            //Al asignar 'e.Location' a 'coordenadas', estamos actualizando la posici�n previa del cursor del rat�n para que coincida con su posici�n actual.

            coordenadas = e.Location;
        }

        private void pbFirma2_MouseMove(object sender, MouseEventArgs e)
        {
            //Dibuja la firma mientras muevo el mouse

            if (click)
            {
                //Preguntar bien para que carajo se usa esto

                using (Graphics g = pbFirma2.CreateGraphics())
                {
                    g.DrawLine(Pens.DarkGreen, coordenadas, e.Location);
                    coordenadas = e.Location;
                }
            }
        }

        private void pbFirma2_MouseUp(object sender, MouseEventArgs e)
        {
            //Deja de dibujar cuando suelto el click

            click = false;
        }
    }
}
