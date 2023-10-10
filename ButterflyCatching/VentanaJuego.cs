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
