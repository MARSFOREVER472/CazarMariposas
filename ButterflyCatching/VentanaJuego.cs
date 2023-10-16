using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterflyCatching
{
    public partial class VentanaJuego : Form
    {
        // Variables a declarar en esta clase.

        float tiempoRestante = 10f; // Se acelera el tiempo en velocidad de 10 frames por segundo.
        int mariposasAtrapadas = 0; // La cantidad de mariposas atrapadas se inicializa en 0.
        int detectorTiempo = 0; // Se debe detectar el temporizador para validar la ejecución del sistema.
        int detectorLimite = 0; // Los límites tienen que detectarse para verificar las conidiciones que posee durante la ejecución del juego.
        List<Mariposa> lista_Mariposa = new List<Mariposa>(); // Las mariposas se agrupan mediante una lista de arreglos por imágenes cargadas en el proyecto.
        Random rnd = new Random(); // Variable aleatoria.

        Image[] imagenes_mariposas = { Properties.Resources._01, Properties.Resources._02, Properties.Resources._03, Properties.Resources._04, Properties.Resources._05, Properties.Resources._06, Properties.Resources._07, Properties.Resources._08, Properties.Resources._09, Properties.Resources._10 };

        public VentanaJuego()
        {
            InitializeComponent();
        }

        // Evento para el temporizador del juego.

        private void EventoTemporizador(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // Evento para hacer click a toda la ventana del juego.

        private void HacerClickEvento(object sender, EventArgs e)
        {
            // Método que permite resolver un algoritmo al hacer click en cualquier parte de la ventana de ejecución del juego.

            // Crearemos una iteración "foreach" para que el usuario pueda realizar acciones con varias mariposas.

            foreach (Mariposa mariposa in lista_Mariposa.ToList())
            {
                MouseEventArgs raton = (MouseEventArgs)e; // Añadiremos un control para atrapar las mariposas en la ventana de ejecución del juego.

                if (raton.X >= mariposa.posicionX && raton.Y >= mariposa.posicionY && raton.X < mariposa.posicionX + mariposa.ancho && raton.Y < mariposa.posicionY + mariposa.altura)
                {
                    lista_Mariposa.Remove(mariposa); // Elimina una mariposa dentro de la lista.
                    mariposasAtrapadas++; // Atrapadas las mariposas que se encuentren en su alrededor.
                }
            }
        }

        // Evento para los colores de la interfaz visual del juego.

        private void EventoPaint(object sender, PaintEventArgs e)
        {
            // Evento para editar gráficas simples a la interfaz del juego.

            ImageAnimator.UpdateFrames(); // Las imágenes estarán con extensión .gif.

            // Y esto podría suceder solamente con todas las mariposas.

            foreach (Mariposa mariposa in lista_Mariposa)
            {
                // Se definen gráficas mediante atributos a cada mariposa.

                e.Graphics.DrawImage(mariposa.imagen_mariposa, mariposa.posicionX, mariposa.posicionY, mariposa.ancho, mariposa.altura);
            }
        }

        // Método para crear una mariposa a partir de una imagen

        private void CrearMariposa()
        {
            // Método para poder crear mariposas a partir de imágenes .gif

            // Las imágenes de la mariposa pueden variar en la misma posición.

            int i = rnd.Next(imagenes_mariposas.Length);

            Mariposa nuevaMariposa = new Mariposa(); // Crearemos una mariposa y otras más...
            nuevaMariposa.imagen_mariposa = imagenes_mariposas[i]; // Guarda en una posición determinada para cada mariposa.
            nuevaMariposa.posicionX = rnd.Next(50, this.ClientSize.Width - 200); // Ancho de la mariposa mediante su posición en X.
            nuevaMariposa.posicionY = rnd.Next(50, this.ClientSize.Height - 200); // Altura de la mariposa mediante su posición en Y.
            lista_Mariposa.Add(nuevaMariposa); // Añade una mariposa a la lista.
            ImageAnimator.Animate(nuevaMariposa.imagen_mariposa, this.OnFrameChangedHandler); // Animación de las imágenes por extensión (.gif).


        }

        // Soporte para la interfaz del juego.

        private void OnFrameChangedHandler(object? sender, EventArgs e)
        {
            this.Invalidate();
        }

        // Método para reiniciar el juego.

        private void ReiniciarJuego()
        {
            // EN INSTANTES...
        }

        // Método para finalizar la partida.

        private void JuegoTerminado()
        {
            // EN INSTANTES...
        }
    }
}
