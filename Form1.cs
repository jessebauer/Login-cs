namespace Login
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = textLogin.Text;
            MessageBox.Show("Olá " + nome);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txtSenha2.Text);
            if (num < 0)
                MessageBox.Show("INFORMOU NEGATIVO");
            else
                MessageBox.Show("INFORMOU POSITIVO");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textLogin.Clear();
            txtSenha2.Clear();
        }
    }
}