namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //se declaran las varibales
            double Radio, Altura;
            double BaseA, LateralA, AreaT;
            double Volumen;
            //se almacenan los datos de los campos de textos en una varible
            Radio = double.Parse(radio.Text);
            Altura = double.Parse(altura.Text);
            //se hacen las operaciones
            BaseA = Radio * Radio * Math.PI;
            LateralA = 2 * Math.PI * Radio * Altura;
            AreaT = 2 * Math.PI * Radio * (Altura+Radio);
            Volumen = Math.PI * Radio * Radio * Altura;
            //se imprimen los resultados, el signo # es para decir el numero de decimales que queremos
            BaseArea.Text = BaseA.ToString("0.##");
            LateralArea.Text = LateralA.ToString("0.##");
            AreaTotl.Text = AreaT.ToString("0.##");
            volumen.Text = Volumen.ToString("0.##");
        }
    }
}