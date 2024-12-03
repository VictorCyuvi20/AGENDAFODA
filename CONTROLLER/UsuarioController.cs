using AGENDAFODA.Data;
using AGENDAFODA.VariabeGoblal;
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
                string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);" +
                    $"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';" +
                    $"GRANT ALL PRIVILEGES ON dbagenda.* TO '{usuario}'@'%';";

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

        public bool DelUsuario(string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "DELETE FROM tbUsuarios WHERE usuario = @usuario";
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
                MessageBox.Show($"{erro.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
    

        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"Select nome, usuario, telefone, senha FROM tbUsuarios;";

                conexao.Open();

                MySqlDataAdapter adaptar = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptar.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }
        public bool logUsuario(string usuario, string senha)
        {

            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(); 

                string sql =  $@"select usuario, senha, nome, telefone from tbUsuarios
                               where usuario = @usuario
                               and BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    UserSession.usuario = resultado.GetString("usuario");
                    UserSession.nome = resultado.GetString("nome");
                    UserSession.senha = resultado.GetString("senha"); 
                    conexao.Close() ;
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro}");
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}