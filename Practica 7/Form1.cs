namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GradosF_Click(object sender, EventArgs e)
        {
            double v1, far1;
            v1 = double.Parse(grados.Text);
            far1 = v1 * (9.0 / 5.0) + 32;
            resultado.Text = far1.ToString("0.##");
            dato.Text = ("Fahrenheit");
        }

        private void GradosC_Click(object sender, EventArgs e)
        {
            double v2, cen1;
            v2 = double.Parse(grados.Text);
            cen1 = (v2 - 32) * (5.0 / 9.0);
            resultado.Text = cen1.ToString("0.##");
            dato.Text = ("Centigrados");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            grados.Text = "";
            resultado.Text = "";
        }
    }
}