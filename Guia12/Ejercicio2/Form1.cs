using System.Configuration;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.lbMostrarValor.Text = tbValor.Text;
            ventana.ShowDialog();
        }
    }
}
