namespace Practica_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            private void Suma_Click(object sender, EventArgs e)
        {
            //se declaran las variables num1 y num2 donde se almacenaran los datos ingresados
            int num1 = Int32.Parse(Numero1.Text);
            int num2 = Int32.Parse(Numero2.Text);
            //se hace la suma de los 2 numeros ingresados
            int suma = num1 + num2;
            //El resultado de la suma
            resultado.Text = "El resultado de la operacion es: " + suma;
        }
    }
}