using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            figuras = new Figura[5] 
            {
                new Circulo(25),
                new Rectangulo(35,40),
                new Cuadrado(50),
                new TrianguloIsosceles(60,65),
                new TrianguloEquilatero(75),
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

            for (int i = 0; i < figuras.Length; i++)
            {
                Pen pen = new Pen(ColorAleatorioConContraste());
                figuras[i].Dibujar(pen, gr, 10 + i * 68, 60);
                pen.Dispose();
            }

        }

        private Color ColorAleatorioConContraste()
        {
            Color color;
            do
            {
                color = Color.FromArgb(
                    random.Next(256),
                    random.Next(256),
                    random.Next(256)
                );
            } while (color.GetBrightness() > 0.75);

            return color;
        }
    }
}
