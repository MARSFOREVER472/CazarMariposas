namespace ButterflyCatching
{
    public partial class Form1 : Form
    {
        // Variables a declarar en esta clase:

        float tiempoRestante = 10f; // Tiempo restante.
        int atrapadas = 0; // cantidad de mariposas atrapadas inicializa en 0.
        int detectorTiempo = 0; // Temporizador detectado.
        int detectorLimite = 30; // El tiempo se detecta mediante cuenta regresiva (30 segundos).
        List<Mariposa> lista_mariposa = new List<Mariposa>(); // Se crea una lista para cada mariposa que encuentre en ella.
        Random rnd = new Random(); // Variable Aleatoria.

        // Se importan las imágenes a la interfaz del juego.

        Image[] butterfly_images = { Properties.Resources._01, Properties.Resources._02, Properties.Resources._03, Properties.Resources._04, Properties.Resources._05, Properties.Resources._06, Properties.Resources._07, Properties.Resources._08, Properties.Resources._09, Properties.Resources._10 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Método que permite inicializar el juego completo de la interfaz.

            Form1 juego = new Form1(); // Para el juego completo en general.
            juego.Show(); // Muestra la ejecución de la interfaz del juego.
        }
    }
}