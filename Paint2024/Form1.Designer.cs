namespace Paint2024
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
            piBoxPapel = new PictureBox();
            btnBorrador = new Button();
            btnPincel = new Button();
            trackBarTamanioPincel = new TrackBar();
            picBoxNegro = new PictureBox();
            picBoxColores = new PictureBox();
            labelR = new Label();
            labelG = new Label();
            labelB = new Label();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            colorDialog1 = new ColorDialog();
            btnFondo = new Button();
            lblTamanio = new Label();
            btnTriangulo = new Button();
            btnCirculo = new Button();
            btnCuadrado = new Button();
            ((System.ComponentModel.ISupportInitialize)piBoxPapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamanioPincel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNegro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColores).BeginInit();
            SuspendLayout();
            // 
            // piBoxPapel
            // 
            piBoxPapel.BackColor = Color.White;
            piBoxPapel.Location = new Point(156, 12);
            piBoxPapel.Name = "piBoxPapel";
            piBoxPapel.Size = new Size(835, 637);
            piBoxPapel.SizeMode = PictureBoxSizeMode.StretchImage;
            piBoxPapel.TabIndex = 0;
            piBoxPapel.TabStop = false;
            piBoxPapel.Click += piBoxPapel_Click;
            piBoxPapel.MouseDown += piBoxPapel_MouseDown;
            piBoxPapel.MouseMove += piBoxPapel_MouseMove;
            piBoxPapel.MouseUp += piBoxPapel_MouseUp;
            // 
            // btnBorrador
            // 
            btnBorrador.Location = new Point(23, 26);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(112, 34);
            btnBorrador.TabIndex = 1;
            btnBorrador.Text = "Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // btnPincel
            // 
            btnPincel.Location = new Point(23, 66);
            btnPincel.Name = "btnPincel";
            btnPincel.Size = new Size(112, 34);
            btnPincel.TabIndex = 2;
            btnPincel.Text = "Pincel";
            btnPincel.UseVisualStyleBackColor = true;
            btnPincel.Click += btnPincel_Click;
            // 
            // trackBarTamanioPincel
            // 
            trackBarTamanioPincel.Location = new Point(23, 106);
            trackBarTamanioPincel.Maximum = 20;
            trackBarTamanioPincel.Minimum = 1;
            trackBarTamanioPincel.Name = "trackBarTamanioPincel";
            trackBarTamanioPincel.Orientation = Orientation.Vertical;
            trackBarTamanioPincel.Size = new Size(69, 179);
            trackBarTamanioPincel.TabIndex = 3;
            trackBarTamanioPincel.Value = 3;
            trackBarTamanioPincel.Scroll += trackBarTamanioPincel_Scroll;
            // 
            // picBoxNegro
            // 
            picBoxNegro.BackColor = SystemColors.ActiveCaptionText;
            picBoxNegro.Location = new Point(23, 329);
            picBoxNegro.Name = "picBoxNegro";
            picBoxNegro.Size = new Size(45, 44);
            picBoxNegro.TabIndex = 4;
            picBoxNegro.TabStop = false;
            picBoxNegro.Click += picBoxNegro_Click;
            // 
            // picBoxColores
            // 
            picBoxColores.BackColor = Color.OrangeRed;
            picBoxColores.Location = new Point(90, 329);
            picBoxColores.Name = "picBoxColores";
            picBoxColores.Size = new Size(45, 44);
            picBoxColores.TabIndex = 5;
            picBoxColores.TabStop = false;
            picBoxColores.Click += picBoxColores_Click;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Location = new Point(23, 391);
            labelR.Name = "labelR";
            labelR.Size = new Size(23, 25);
            labelR.TabIndex = 6;
            labelR.Text = "R";
            // 
            // labelG
            // 
            labelG.AutoSize = true;
            labelG.Location = new Point(23, 428);
            labelG.Name = "labelG";
            labelG.Size = new Size(24, 25);
            labelG.TabIndex = 7;
            labelG.Text = "G";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(23, 465);
            labelB.Name = "labelB";
            labelB.Size = new Size(22, 25);
            labelB.TabIndex = 8;
            labelB.Text = "B";
            // 
            // txtR
            // 
            txtR.Location = new Point(55, 388);
            txtR.Name = "txtR";
            txtR.Size = new Size(80, 31);
            txtR.TabIndex = 9;
            txtR.Text = "0";
            // 
            // txtG
            // 
            txtG.Location = new Point(55, 425);
            txtG.Name = "txtG";
            txtG.Size = new Size(80, 31);
            txtG.TabIndex = 10;
            txtG.Text = "0";
            // 
            // txtB
            // 
            txtB.Location = new Point(55, 462);
            txtB.Name = "txtB";
            txtB.Size = new Size(80, 31);
            txtB.TabIndex = 11;
            txtB.Text = "0";
            // 
            // btnFondo
            // 
            btnFondo.Location = new Point(879, 615);
            btnFondo.Name = "btnFondo";
            btnFondo.Size = new Size(112, 34);
            btnFondo.TabIndex = 12;
            btnFondo.Text = "Fondo";
            btnFondo.UseVisualStyleBackColor = true;
            btnFondo.Click += btnFondo_Click;
            // 
            // lblTamanio
            // 
            lblTamanio.AutoSize = true;
            lblTamanio.Location = new Point(23, 288);
            lblTamanio.Name = "lblTamanio";
            lblTamanio.RightToLeft = RightToLeft.No;
            lblTamanio.Size = new Size(97, 25);
            lblTamanio.TabIndex = 13;
            lblTamanio.Text = "Tamanio: 3";
            // 
            // btnTriangulo
            // 
            btnTriangulo.Location = new Point(23, 523);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(112, 34);
            btnTriangulo.TabIndex = 14;
            btnTriangulo.Text = "Triangulo";
            btnTriangulo.UseVisualStyleBackColor = true;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(23, 563);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(112, 34);
            btnCirculo.TabIndex = 15;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Location = new Point(23, 603);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(112, 34);
            btnCuadrado.TabIndex = 16;
            btnCuadrado.Text = "Cuadrado";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 661);
            Controls.Add(btnCuadrado);
            Controls.Add(btnCirculo);
            Controls.Add(btnTriangulo);
            Controls.Add(lblTamanio);
            Controls.Add(btnFondo);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(labelB);
            Controls.Add(labelG);
            Controls.Add(labelR);
            Controls.Add(picBoxColores);
            Controls.Add(picBoxNegro);
            Controls.Add(trackBarTamanioPincel);
            Controls.Add(btnPincel);
            Controls.Add(btnBorrador);
            Controls.Add(piBoxPapel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piBoxPapel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamanioPincel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNegro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private PictureBox piBoxPapel;
        private Button btnBorrador;
        private Button btnPincel;
        private TrackBar trackBarTamanioPincel;
        private PictureBox picBoxNegro;
        private PictureBox picBoxColores;
        private Label labelR;
        private Label labelG;
        private Label labelB;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private ColorDialog colorDialog1;
        private Button btnFondo;
        private Label lblTamanio;
        private Button btnTriangulo;
        private Button btnCirculo;
        private Button btnCuadrado;
    }
}
