using MySql.Data.MySqlClient;
using projetoAgenda.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgenda.Controler
{
    internal class categoriaController
    {
        public bool AddCategoria(string categoria)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_categorias (categoria) VALUES (@categoria);";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@categoria", categoria);


                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
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
                MessageBox.Show($"erro ao efetuar o cadastro :{erro.Message}");

                return false;
            }
        }

        public DataTable GetCategoria()
        {
            MySqlConnection conexao = null;


            try
            {
                // cria conexao, usei a classe ja criada 
                conexao = conexaoDB.CriarConexao();

                // select que vai retornar 
                string sql = @"Select cod AS 'codigo', categoria AS 'categoria' from tb_categorias;";

                //abri a conexao
                conexao.Open();

                //adapter 
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                //tabela vazia 
                DataTable tabela = new DataTable();

                //preenchendo a  tabela 
                adapter.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao recuperar a categoria: {erro.Message} ");
                
                return new DataTable();
            }
            finally
            {

                conexao.Close();
            }



        }
    }
}

        




