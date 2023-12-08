namespace Practica_2
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

        //        //Ejecuta las instrucciones al presionar el boton de saludo

        private void Enviar_Click(object sender, EventArgs e)
        {
            //guarda en la etiqueta saludo el valor del campo de texto
            Saludo.Text = "Hello, " + texto.Text + " Bienvenido!";
        }
    }
}