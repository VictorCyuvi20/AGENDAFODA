namespace AGENDAFODA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTTCADRATRO_Click(object sender, EventArgs e)
        {
            FRMCADASTRAR PAGCADASTRO = new FRMCADASTRAR();
            PAGCADASTRO.Show();
            this.Hide();
        }

        private void INPUTEMAIL_TextChanged(object sender, EventArgs e)
        {
            if (INPUTEMAIL.Text != "" && INPUTSENHA.Text.Length >= 8)
            {
                BTTENTRAR.Enabled = true;
            }
            else
            {
                BTTENTRAR.Enabled = false;
            }
        }

        private void INPUTSENHA_TextChanged(object sender, EventArgs e)
        {
            if (INPUTEMAIL.Text != "" && INPUTSENHA.Text.Length >= 8)
            {
                BTTENTRAR.Enabled = true;
            }
            else
            {
                BTTENTRAR.Enabled = false;
            }
        }
    }
}
