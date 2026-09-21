using System.Globalization;

namespace Problema1_EstuardoChavarriaIVC5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = int.Parse(txtDia.Text);
                int mes = int.Parse(txtMes.Text);
                int anio = int.Parse(txtAnio.Text);

                DateTime fecha = new DateTime(anio, mes, dia);

                CultureInfo cultura = new CultureInfo("es-ES");

                txtResultado.Text = fecha.ToString(
                    "d 'de' MMMM 'de' yyyy",
                    cultura);
            }
            catch
            {
                MessageBox.Show("Ingrese una fecha válida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        {
            txtDia.Clear();
            txtMes.Clear();
            txtAnio.Clear();
            txtResultado.Clear();

            txtDia.Focus();
        }
    }
    }
}
