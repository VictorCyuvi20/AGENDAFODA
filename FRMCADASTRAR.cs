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
    }
}
