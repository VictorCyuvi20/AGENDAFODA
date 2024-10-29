using AGENDAFODA.CONTROLER;
using AGENDAFODA.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDAFODA
{
    public partial class FRMCADASTRAR : Form
    {
        public FRMCADASTRAR()
        {
            InitializeComponent();
        }
        private void campobranco()
        {
            if (INPUTNOME.Text != "" && INPUTUSUARIO.Text != "")
            {
                BTTCADASTRAR.Enabled = true;

            }
            else
            {
                BTTCADASTRAR.Enabled = false;

            }
            if (INPUTNOME.Text != "")
            {
                BRANCO.Visible = false;
            }
            else
            {
                BRANCO.Visible = true;
            }
            if (INPUTUSUARIO.Text != "")
            {
                BRANCO2.Visible = false;
            }
            else
            {
                BRANCO2.Visible = true;
            }
        }

        private void tamanhosenha()
        {
            if (INPUTSENHA.Text.Length > 8)
            {
                BTTCADASTRAR.Enabled = true;

            }
            else
            {
                BTTCADASTRAR.Enabled = false;

            }
            if (INPUTSENHA.Text != INPUTSENHA2.Text)
            {
                VERIFICASENHA.Visible = false;
            }
            else
            {
                VERIFICASENHA.Visible = true;
            }
        }

        private void INPUTNOME_TextChanged(object sender, EventArgs e)
        {
            campobranco();

        }

        private void FRMCADASTRAR_Load(object sender, EventArgs e)
        {

        }

        private void INPUTUSUARIO_TextChanged(object sender, EventArgs e)
        {
            campobranco();
        }

        private void INPUTSENHA_TextChanged(object sender, EventArgs e)
        {
            tamanhosenha();
        }

        private void BTTCADASTRAR_Click(object sender, EventArgs e)
        {
            string nome = INPUTNOME.Text;
            string usuario = INPUTUSUARIO.Text;
            string telefone = INPUTTELEFONE.Text;
            string senha = INPUTSENHA.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO");
            }

        }
    }
}
