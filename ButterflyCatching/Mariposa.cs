using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterflyCatching
{
    // Clase principal por defecto.

    internal class Mariposa
    {
        // Variables a declarar:

        public Image imagen_mariposa; // Mariposa del juego.
        public int posicionX; // Posición de la mariposa en X.
        public int posicionY; // Posición de la mariposa en Y.
        public int altura; // Altura de la mariposa.
        public int ancho; // Ancho de la mariposa.
        public int velocidadX, velocidadY, limite, limiteMovimientos; // Habilidades de la mariposa.
        Random rnd = new Random(); // Variable aleatoria.

        // El constructor de esta clase tiene que constar algunos parámetros asociados a las variables declaradas anteriormente.

        public Mariposa()
        {
            limite = rnd.Next(200, 400); // El límite de la posición de cada mariposa puede variar.
            limiteMovimientos = limite; // Los movimientos de la mariposa son limitados.

            velocidadX = rnd.Next(-5, 5); // Su velocidad en X para estas mariposas pueden variar dependiendo del rango establecido.
            velocidadY = rnd.Next(-5, 5); // Su velocidad en Y para estas mariposas pueden variar dependiendo del rango establecido.

            altura = 43; // La altura de la mariposa tiene que medir 43 metros.
            ancho = 60; // El ancho de la mariposa tiene que medir 60 metros.
        }

        // Crearemos un nuevo método para mover la mariposa hacia los lados.

        public void MoverMariposa()
        {
            limiteMovimientos--; // Los movimientos tienen un límite comenzando con una cuenta regresiva.

            if (limiteMovimientos < 0) // Si los movimientos limitados llegaron a 0.
            {
                if (velocidadX < 0) // Si su velocidad en X es menor que 0.
                {
                    velocidadX = rnd.Next(2, 5);
                }

                else // En caso contrario...
                {
                    velocidadX = rnd.Next(-5, -2);
                }

                if (velocidadY < 0) // Si su velocidad en Y es menor que 0.
                {
                    velocidadY = rnd.Next(2, 5);
                }

                else // En caso contrario...
                {
                    velocidadY = rnd.Next(-5, -2);
                }

                limiteMovimientos = rnd.Next(200, limite); // Los movimientos llegan a su límite.
            }
        }
    }
}
