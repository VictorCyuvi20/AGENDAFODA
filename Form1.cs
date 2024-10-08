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
    }
}
