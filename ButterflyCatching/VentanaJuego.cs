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
            // EN INSTANTES...
        }

        // Evento para los colores de la interfaz visual del juego.

        private void EventoPaint(object sender, PaintEventArgs e)
        {
            // EN INSTANTES...
        }

        // Método para crear una mariposa a partir de una imagen

        private void CrearMariposa()
        {
            // EN INSTANTES...
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
