
using AGENDAFODA.CONTROLER;
using AGENDAFODA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDAFODA.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria FrmCategoria = new FrmCategoria();
            FrmCategoria.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            APENAS.Text = $"BEM-VINDO SENHOR(A): {VariabeGoblal.UserSession.nome.ToString()}, TENHA UM ÓTIMO DIA";

        }

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eNCERRARSESSÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
