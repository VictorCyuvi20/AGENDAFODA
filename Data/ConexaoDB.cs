﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDAFODA.Data
{
     internal static class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            string stringconexao = "Server=127.0.0.1;DAtabase=dbagenda;User ID=root;Password=root;";

            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;
        }
    }
}
