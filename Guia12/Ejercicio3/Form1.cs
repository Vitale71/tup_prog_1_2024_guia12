namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.ShowDialog();
            int n = 0;
            while (n < 10 && ventana.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
