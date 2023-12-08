namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void invertir_Click(object sender, EventArgs e)
        {
            //se declaran las variables
            int a, b, c, d;
            //se guarda el valor en la variable asignada
            a = int.Parse(text1.Text);
            b = int.Parse(text2.Text);
            c = int.Parse(text3.Text);
            d = int.Parse(text4.Text);
            //se escribe el valor de la variable en el campo de texto
            textA.Text = d.ToString();
            textB.Text = c.ToString();
            textC.Text = b.ToString();
            textD.Text = a.ToString();

        }
    }
}