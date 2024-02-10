using System.Drawing;
using System.Reflection;

namespace Paint2024
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;
        bool figCirculo = false;
        bool figCuadrado = false;
        bool figTriangulo = false;
        int sX, sY, cX, cY;


        public Form1()
        {
            InitializeComponent();
            piBoxPapel.Image = new Bitmap(piBoxPapel.Height, piBoxPapel.Width);
            papel = piBoxPapel.CreateGraphics();    // Para crear lienzo
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;    //Suavisa movimiento mouse
            tamanioPincel = trackBarTamanioPincel.Value; //Nuestro pincel sera asignado al tamanio del trackbar
            R = int.Parse(txtR.Text); //R sera igual a lo que tengamos en el texto del cuadrito
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
            figCirculo = false;
            figCuadrado = false;
            figTriangulo = false;

        }

        private void piBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true; // Nos dice que estamos pintanto
            x = e.X; y = e.Y;
            piBoxPapel.Cursor = Cursors.Cross; // Deteccion movimiento del mouse
            cX = e.X;
            cY = e.Y;

        }

        private void piBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false; // Nos dice que estamos pintanto

            sX = x - cX;
            sY = y - cY;

            if (figCirculo == true)
            {
                papel.DrawEllipse(pen, cX, cY, sX, sY);
            }

            if (figCuadrado == true)
            {
                papel.DrawRectangle(pen, cX, cY, sX, sY);
            }

            if (figTriangulo == true)
            {
                Graphics triangulo;

                triangulo = piBoxPapel.CreateGraphics();
                //triangulo.DrawLine(pen, 40, 200, 400, 200);
                //triangulo.DrawLine(pen, 40, 200, 200, 40);
                //triangulo.DrawLine(pen, 200, 40, 400, 200

                triangulo.DrawLine(pen, cX, cY, x, y);
                triangulo.DrawLine(pen, sX, sY, cX, cY);
                triangulo.DrawLine(pen, x, y, sX, sY);
            }

        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            borrar = true;
            pintar = false;
            figCirculo = false;
            figCuadrado = false;
            figTriangulo = false;
        }

        private void piBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                CambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moviendo && borrar)
            {
                CambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;


        }
        private void CambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBarTamanioPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void picBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void picBoxColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //Desplegamos el menu seleccion de color
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();

            }
        }

        private void piBoxPapel_Click(object sender, EventArgs e)
        {

        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog(); //Permite selccionar archivos del programa
            imagen.Filter = "archivos de imagenes (*.png; *.jpg)| *.png; .jpg";

            if (imagen.ShowDialog() == DialogResult.OK) //Se abre una ventana y si el usuario selecciona imagen
            {
                piBoxPapel.Image = Image.FromFile(imagen.FileName); //Aniadela al papel
            }
        }

        private void trackBarTamanioPincel_Scroll(object sender, EventArgs e)
        {
            lblTamanio.Text = "Tamanio " + trackBarTamanioPincel.Value.ToString();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            borrar = false;
            pintar = false;
            figCirculo = true;
            figCuadrado = false;
            figTriangulo = false;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            borrar = false;
            pintar = false;
            figCirculo = false;
            figCuadrado = true;
            figTriangulo = false;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            borrar = false;
            pintar = false;
            figCirculo = false;
            figCuadrado = false;
            figTriangulo = true;
        }
    }
}

