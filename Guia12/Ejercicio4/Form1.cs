namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double [] valores = new double [20];

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 modelo = new Form2();
            int contador = 0;
            while (contador < 20 && modelo.ShowDialog() == DialogResult.OK)
            {
                valores[contador++] = Convert.ToDouble(modelo.tbValor.Text);
                modelo.tbValor.Clear();
            }
            lbCantidad.Text = contador.ToString();
            for (int i = 0; i < contador; i++)
            { 
                lsbListado.Items.Add(valores[i]);
            }

        }
    }
}
