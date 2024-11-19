using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGENDAFODA.VariabeGoblal;

namespace AGENDAFODA.Views
{
    public partial class TESTEFODA : Form
    {
        public TESTEFODA()
        {
            InitializeComponent();
        }

        private void BTT_GUARDA_Click(object sender, EventArgs e)
        {
            UserSession.nome = TXT_NOME.Text;
            UserSession.usuario = TXT_USU.Text;
            UserSession.senha = TXT_SENHA.Text;
        }

        private void BTT_MOSTRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
            MessageBox.Show(UserSession.senha);
            MessageBox.Show($"BEM VINDO {UserSession.nome}");
        }
    }
}
