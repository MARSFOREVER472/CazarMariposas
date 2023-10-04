namespace ButterflyCatching
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Viner Hand ITC", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 10);
            label1.Name = "label1";
            label1.Size = new Size(608, 220);
            label1.TabIndex = 0;
            label1.Text = "TUTORIAL DE CAZAR MARIPOSAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(300, 300);
            button1.Name = "button1";
            button1.Size = new Size(300, 100);
            button1.TabIndex = 1;
            button1.Text = "Comenzar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._01;
            pictureBox1.Location = new Point(100, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._02;
            pictureBox2.Location = new Point(150, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._09;
            pictureBox3.Location = new Point(650, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._06;
            pictureBox4.Location = new Point(700, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 450);
            label2.Name = "label2";
            label2.Size = new Size(856, 132);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(878, 594);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Cazar Mariposas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
    }
}