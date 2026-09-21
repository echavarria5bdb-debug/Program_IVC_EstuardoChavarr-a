namespace Problema3_EstuardoChavarriaIVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtEdad.Clear();
            txtSalario.Clear();
            txtDescripcion.Clear();

            errorProvider1.Clear();

            txtNombres.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool correcto = true;

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar los nombres.");
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                errorProvider1.SetError(txtEdad, "Debe ingresar la edad.");
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar el salario.");
                correcto = false;
            }

            if (!correcto)
            {
                return;
            }

            MessageBox.Show("Datos ingresados correctamente.");
        }
    }
}
