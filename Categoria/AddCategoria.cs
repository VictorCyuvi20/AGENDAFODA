using AGENDAFODA.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDAFODA.Categoria
{
    internal class AddCategoria
    {
        public bool AddCatego(string categoria, string nome, string telefone)
        {
            try
            {

                MySqlConnection conexao = ConexaoDB.CriarConexao();
                string sql = "INSERT INTO tbCatego (categoria, nome, telefone) VALUES (@categoria, @nome, @telefone);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);

                int linhasafetadas = comando.ExecuteNonQuery();

                conexao.Close();

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
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

        }
    }
}
