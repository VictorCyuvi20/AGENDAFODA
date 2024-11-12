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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTT_CADASTRAR_CATE_Click(object sender, EventArgs e)
        {



            CategoriaController controlecategoria = new CategoriaController();

            bool resultado = controlecategoria.AddCatego(CATEGORIA.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
  
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o cadastro");
            }


        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaController controlecategoria1 = new CategoriaController();
            DataTable tabela = controlecategoria1.GetCategorias();
            TABELA_CONTATOS.DataSource = tabela;
        }
    }
}
