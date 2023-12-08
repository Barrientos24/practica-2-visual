namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            float basE = float.Parse(Base.Text);
            float altura = float.Parse(Altura.Text);
            float resultado = basE * altura / 2;
            Resultado.Text = resultado.ToString();
        }

    }
}