using AGENDAFODA.CONTROLER;
using AGENDAFODA.CONTROLLER;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void TABELA_USUARIO_Enter(object sender, EventArgs e)
        {

        }

        private void atualizatabela()
        {
            UsuarioController getusuarios = new UsuarioController();
            DataTable tabela_usuarios = getusuarios.GetUsuarios();
            TABELA_USUARIO.DataSource = tabela_usuarios;
        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {
            string usuario = TABELA_USUARIO.SelectedRows[0].Cells[0];
            UsuarioController excluirusuario = new UsuarioController();
            excluirusuario.ExUsuario(usuario);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            atualizatabela();
        }
    }
}
