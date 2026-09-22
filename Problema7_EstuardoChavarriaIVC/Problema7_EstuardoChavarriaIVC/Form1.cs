namespace Problema7_EstuardoChavarriaIVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double total = 0;
            double aPagar;
            double resta;

            if (chkJava.Checked)
            {
                total += 150;
            }

            if (chkCSharp.Checked)
            {
                total += 160;
            }

            if (chkOracle.Checked)
            {
                total += 140;
            }

            if (chkSQLServer.Checked)
            {
                total += 170;
            }

            if (!double.TryParse(txtAPagar.Text, out aPagar))
            {
                MessageBox.Show("Ingrese una cantidad válida en A pagar.");
                txtAPagar.Focus();
                return;
            }

            if (aPagar < 0)
            {
                MessageBox.Show("La cantidad a pagar no puede ser negativa.");
                txtAPagar.Focus();
                return;
            }

            resta = total - aPagar;

            txtTotal.Text = total.ToString("0.00");
            txtResta.Text = resta.ToString("0.00");
        }
    }
}
