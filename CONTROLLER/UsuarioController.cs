using AGENDAFODA.Data;
using AGENDAFODA.VariabeGoblal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public bool logUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao(); 9

                string sql =  $@"select usuario, senha, nome, telefone from tbUsuarios
                               where usuario = '{usuario}'
                               and BINARY senha = {senha};";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    UserSession.usuario = resultado.GetString(0);
                    UserSession.nome = resultado.GetString(2);
                    UserSession.senha = resultado.GetString(1); 
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
        }
    }
}