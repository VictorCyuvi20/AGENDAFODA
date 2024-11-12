using AGENDAFODA.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDAFODA.CONTROLLER
{
    internal class CategoriaController
    {
        public bool AddCatego(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();
    
                string sql = @"INSERT INTO tbCategoria (nome_categoria) VALUES (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

                int linhasafetadas = comando.ExecuteNonQuery();


                if (linhasafetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro da categoria: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;
            
            try
            {
                //Criar Conexão
                conexao = ConexaoDB.CriarConexao();

                string sql = "SELECT cod, nome_categoria FROM tbCategoria;";

                conexao.Open();
                //Adaptando o sql, conexão
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criou tabela
                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categoria: {erro.Message}");

                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
          
        }

        public bool ExCategoria(string codigo)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"DELETE from tbCategoria WHERE (cod) VALUES (@codigo);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", codigo);

                int linhasafetadas = comando.ExecuteNonQuery();


                if (linhasafetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao deletar a categoria: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
