namespace Problema2_EstuardoChvarriaIVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string cargo = txtCargo.Text.Trim().ToLower();

            switch (cargo)
            {
                case "gerente":
                    txtSueldo.Text = "Q. 5000.00";
                    break;

                case "administrador":
                    txtSueldo.Text = "Q. 4500.00";
                    break;

                case "secretaria":
                    txtSueldo.Text = "Q. 3500.00";
                    break;

                case "contador":
                    txtSueldo.Text = "Q. 4000.00";
                    break;

                default:
                    txtSueldo.Text = "Cargo no válido";
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
