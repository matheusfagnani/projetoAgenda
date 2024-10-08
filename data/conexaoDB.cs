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
        public MySqlConnection criarConexao()
        {
            string stringConexao = "server=127.0.0.1;Database=bdagenda;user ID=root;password=rooot";
            //conexão//
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            return conexao;
        }
    }
}
