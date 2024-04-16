namespace pryGrabarFirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializa el Bitmap para la firma
            firmaBitmap = new Bitmap(pbFirma2.Width, pbFirma2.Height);
            // Borra el Bitmap (lo deja en blanco)
            using (Graphics g = Graphics.FromImage(firmaBitmap))
            {
                g.Clear(Color.White);
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pbFirma.CreateGraphics();

            Pen lapicera = new Pen(Color.Black);

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

        // Variable para almacenar la firma
        private Bitmap firmaBitmap;

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

                using (Graphics g = Graphics.FromImage(firmaBitmap))
                {
                    g.DrawLine(Pens.Black, coordenadas, e.Location);
                    coordenadas = e.Location;
                }
                // Vuelve a dibujar la firma en el PictureBox
                pbFirma2.Image = firmaBitmap;
            }
        }

        private void pbFirma2_MouseUp(object sender, MouseEventArgs e)
        {
            //Deja de dibujar cuando suelto el click

            click = false;
        }

        //Se graba el png pero no se graba la firma, tipo como que crea un rectangulo en formato png pero vacio, no toma el dibujo
        //Utilice el Bitmap que es una clase que dibuja los bits y los transforma a png, preguntar bien que es eso 
        private void btnGrabarFirma_Click(object sender, EventArgs e)
        {
            if (firmaBitmap != null)
            {
                // Guarda la firma en el disco
                string rutaGuardado = @"C:\Users\fedee\Downloads\firmaguardada.png"; // Cambia la ruta seg�n tu preferencia
                firmaBitmap.Save(rutaGuardado, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Firma guardada correctamente.");
            }
            else
            {
                MessageBox.Show("No hay firma para guardar.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa el Bitmap para la firma
            firmaBitmap = new Bitmap(pbFirma2.Width, pbFirma2.Height);
            // Borra el Bitmap (lo deja en blanco)
            using (Graphics g = Graphics.FromImage(firmaBitmap))
            {
                g.Clear(Color.White);
            }
        }
    }
}
