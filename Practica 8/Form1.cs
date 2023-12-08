using System.Buffers.Text;
using System;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radio.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            area.Text = area1.ToString("0.##");
            volumen.Text = volumen1.ToString("0.##");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            radio.Text = "";
            volumen.Text = "";
            area.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cal1_Click(object sender, EventArgs e)
        {
            double base1, altura1, area2;
            base1 = double.Parse(base2.Text);
            altura1 = double.Parse(altura2.Text);
            area2 = base1 * altura1 / 2;
            resultado.Text = area2.ToString("0.##");
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            base2.Text = "";
            altura2.Text = "";
            resultado.Text = "";
        }

        private void calcular3_Click(object sender, EventArgs e)
        {
            double lado1, area31, volumen31;
            lado1 = double.Parse(lado.Text);
            area31 = 6 * Math.Pow(lado1, 2);
            volumen31 = Math.Pow(lado1, 3);

            area3.Text = area31.ToString("0.##");
            volumen3.Text = volumen31.ToString("0.##");
        }

        private void borrar3_Click(object sender, EventArgs e)
        {
            area3.Text = "";
            volumen3.Text = "";
            lado.Text = "";
        }

        private void Calcular4_Click(object sender, EventArgs e)
        {
            double radio41, altura41, volumen41, area41;
            radio41 = double.Parse(radio4.Text);
            altura41 = double.Parse(altura4.Text);
            area41 = 2 * Math.PI * radio41 * altura41 + 2 * Math.PI * Math.Pow(radio41, 2);
            volumen41 = Math.PI * Math.Pow(radio41, 2) * altura41;

            area4.Text = area41.ToString("0.##");
            volumen4.Text = volumen41.ToString("0.##");
        }

        private void Borrar4_Click(object sender, EventArgs e)
        {
            area4.Text = "";
            volumen4.Text = "";
            altura4.Text = "";
            radio4.Text = "";
        }

        private void calcular5_Click(object sender, EventArgs e)
        {
            double diametro51, diametro52, area51;
            diametro51 = double.Parse(diametro5.Text);
            diametro52 = double.Parse(diam5.Text);
            area51 = diametro51 * diametro52 / 2;
            resultado5.Text = area51.ToString("0.##");
        }

        private void borrar5_Click(object sender, EventArgs e)
        {
            resultado5.Text = "";
            diametro5.Text = "";
            diam5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LadoA.Text = "";
            area6.Text = "";
            volumen6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoa, area61, volumen61;
            ladoa = double.Parse(LadoA.Text);
            area61 = 2 * (Math.Pow(3, 0.5)) * Math.Pow(ladoa, 2);
            volumen61 = Math.Pow(2, 0.5) / 3 * Math.Pow(ladoa, 3);
            area6.Text = area61.ToString("0.##");
            volumen6.Text = volumen61.ToString("0.##");
        }

    }
}