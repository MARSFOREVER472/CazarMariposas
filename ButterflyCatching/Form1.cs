namespace ButterflyCatching
{
    public partial class Form1 : Form
    {
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