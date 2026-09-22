namespace Problema6_EstuardoChavarriaIVC
{
    public partial class Form1 : Form
    {
        private int canal = 1;
        private int volumen = 0;
        private bool encendida = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirVolumen_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                lblPantalla.Text = "TV APAGADA";
                return;
            }

            if (volumen < 100)
            {
                volumen++;
            }

            lblPantalla.Text = "CANAL: " + canal.ToString("00") +
                               " | VOLUMEN: " + volumen.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encendida = !encendida;

            if (encendida)
            {
                lblPantalla.Text = "CANAL: 01 | VOLUMEN: 01";
            }
            else
            {
                lblPantalla.Text = "TV APAGADA";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (!encendida)
                {
                    lblPantalla.Text = "TV APAGADA";
                    return;
                }

                if (canal < 105)
                {
                    canal++;
                }

                lblPantalla.Text = "CANAL: " + canal.ToString("00") +
                                   " | VOLUMEN: " + volumen.ToString("00");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                lblPantalla.Text = "TV APAGADA";
                return;
            }

            if (canal > 1)
            {
                canal--;
            }

            lblPantalla.Text = "CANAL: " + canal.ToString("00") +
                               " | VOLUMEN: " + volumen.ToString("00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                LblPantalla.Text = "TV APAGADA";
                return;
            }

            if (volumen > 0)
            {
                volumen--;
            }

            lblPantalla.Text = "CANAL: " + canal.ToString("00") +
                               " | VOLUMEN: " + volumen.ToString("00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
