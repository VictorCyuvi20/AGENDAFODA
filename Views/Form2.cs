using AGENDAFODA.CONTROLER;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controleusuario = new UsuarioController();

            bool resultado = controleusuario.logUsuario("Godo", "AlexLindao");

            MessageBox.Show(resultado.ToString());
        }
    }
}
