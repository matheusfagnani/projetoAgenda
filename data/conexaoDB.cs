using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgenda.data
{
    internal class conexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            string stringConexao = "server=127.0.0.1;Database= db_agenda ;user ID=root;password=root";
            //conexão//
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            return conexao;
        }
        static public MySqlConnection Criarconexao()
        {
            string stringConexao = "server=127.0.0.1;Database= db_agenda ;user ID=root;password=root";
            //conexão//
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            return conexao;
        }


    }
}
