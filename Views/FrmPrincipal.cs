using AGENDAFODA.Categoria;
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

        private void novoContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoria addcategoria = new AddCategoria();

            bool resultado = addcategoria.AddCatego(categoria);

        }

    }
}
