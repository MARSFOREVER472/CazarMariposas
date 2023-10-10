namespace ButterflyCatching
{
    partial class VentanaJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblTemporizador = new Label();
            lblCantMariposas = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-4, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemporizador.Location = new Point(12, 403);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(279, 38);
            lblTemporizador.TabIndex = 1;
            lblTemporizador.Text = "Tiempo restante: 00";
            // 
            // lblCantMariposas
            // 
            lblCantMariposas.AutoSize = true;
            lblCantMariposas.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantMariposas.Location = new Point(573, 403);
            lblCantMariposas.Name = "lblCantMariposas";
            lblCantMariposas.Size = new Size(181, 38);
            lblCantMariposas.TabIndex = 2;
            lblCantMariposas.Text = "Atrapadas: 0";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += EventoTemporizador;
            // 
            // VentanaJuego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCantMariposas);
            Controls.Add(lblTemporizador);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "VentanaJuego";
            ShowIcon = false;
            Text = "VentanaJuego";
            Click += HacerClickEvento;
            Paint += EventoPaint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTemporizador;
        private Label lblCantMariposas;
        private System.Windows.Forms.Timer GameTimer;
    }
}