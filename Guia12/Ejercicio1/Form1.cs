namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.ShowDialog();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                lbMostrarValor.Text = $"{ventana.tbValor.Text}";
            }
        }
    }
}
