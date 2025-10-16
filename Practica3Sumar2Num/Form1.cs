namespace Practica3Sumar2Num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2= Int32.Parse(textBox2.Text);
            int sum = num1 + num2;
            label3.Text = "Resultado de la suma = " + sum;
        }
    }
}