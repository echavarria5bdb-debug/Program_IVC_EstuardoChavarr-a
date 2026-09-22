using System.Windows.Forms;

namespace Problema4_EstuardoChavarriaIVC
{
    public partial class Form1 : Form
    {
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombreCompleto;
        private TextBox txtNombre;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtNombreCompleto.Clear();

            txtNombre.Focus();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Text = txtNombre.Text + " "
                + txtApellidoPaterno.Text + " "
                + txtApellidoMaterno.Text;
        }
    }
}
