using AGENDAFODA.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDAFODA.CONTROLER
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try { 

                MySqlConnection conexao = ConexaoDB.CriarConexao();
                string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (LinhasAfetadas > 0)
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
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

        }

        public bool logUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql =  @"select * from tbUsuarios
                               where usuario = @usuario
                               and BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close() ;
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;

                }

            }
            catch
            {
                return false;
            }
        }

        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;

            try
            {
                //Criar Conexão
                conexao = ConexaoDB.CriarConexao();

                string sql = "SELECT usuario, nome FROM tbUsuarios;";

                conexao.Open();
                //Adaptando o sql, conexão
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criou tabela
                DataTable tabela_usuarios = new DataTable();

                adaptador.Fill(tabela_usuarios);

                return tabela_usuarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o usuário: {erro.Message}");

                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }

            public bool ExUsuario(string usuario)
        {
            MySqlConnection conexao = null;

            try 
            { 

                conexao = ConexaoDB.CriarConexao();

                string sql = @"DELETE from tbUsuarios WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

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