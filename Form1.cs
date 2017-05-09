using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika_CW
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color .Blue, 3);
        PointF Srodek = new PointF(200,200);
        PointF P1 = new PointF(0,0);
        PointF P2 = new PointF(0,0);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                g.Clear(Color.White);
                //czyszczenie pola na określony kolor
                g.DrawLine(pen1, 0, 400, 100, 100);
                //rysuje linie łącząca dwa punkty
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);

            g.Clear(Color.White);
            //czyszczenie pola na określony kolor
            g.DrawLine(pen1, 0, 400, this.P1.X, this.P1.Y);
            //rysuje linie łącząca dwa punkty

            //Double.Parse(textBox1.Text);
            //Double.Parse(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e) //prostokąt
        {
            g.DrawLine(pen1, 100, 100, 100, 300);
            g.DrawLine(pen1, 100, 300, 300, 300);
            g.DrawLine(pen1, 300, 300, 300, 100);
            g.DrawLine(pen1, 300, 100, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //Krzywe
        {

        }

        private void button4_Click(object sender, EventArgs e) //Elipsa
        {
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);
            //this.g.DrawEllipse(pen1,this.P1.X,this.P1.Y,this.Srodek.X,this.Srodek.Y);
            this.g.DrawEllipse(pen1, this.Srodek.X, this.Srodek.Y,this.P1.X, this.P1.Y);
        }

        private void button6_Click(object sender, EventArgs e) //Okrąg Punkt po punkcie
        {
            //zaczynamy od góry
            P1.X = (float)200;
            P1.Y = (float)100;
            int alpha = 0;
            for (alpha = 0;alpha <= 360;alpha++)
            {
                this.P2.X = 100 * (float)Math.Cos(alpha);
                this.P2.Y = 100 * (float)Math.Sin(alpha);
                g.DrawLine(pen1, P1, P2);
                this.P1.X = this.P2.X;
                this.P1.Y = this.P2.Y;
            }

        }

        private void button7_Click(object sender, EventArgs e) //
        {

        }

        private void button8_Click(object sender, EventArgs e) //
        {

        }
    }

}
