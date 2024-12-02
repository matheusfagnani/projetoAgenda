using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using projetoAgenda.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgenda.Controler
{
    internal class ContatoController
    {
        public bool AddContato(string contato, string numero, string categoria)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_contato(nome_contato,numero,categoria) VALUES (@nome_contato,@numero,@categoria);";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome_contato", contato);
                comando.Parameters.AddWithValue("@numero", numero);
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
                MessageBox.Show($"erro ao adicionar contato :{erro.Message}");

                return false;
            }


        }
        public bool excluir_contato(int cod)
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao();
                string sql = "DELETE FROM tb_contato where cod = @cod ;";
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@cod", cod);
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
                MessageBox.Show($"erro ao excluir contato:{erro.Message}");

                return false;
            }

        }
        public bool Alterar_Contato(string nome_contato,string numero,string categoria )
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao();
                string sql = " UPDATE tb_contato where nome_contato,numero = @nome_contato,@numero,@categoria;";
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome_contato", nome_contato);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@categoria", categoria);
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
                MessageBox.Show($"erro ao Atualizar categoria :{erro.Message}");

                return false;
            }
        }
    }

}
