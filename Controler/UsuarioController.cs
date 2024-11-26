using MySql.Data.MySqlClient;
using projetoAgenda.data;
using projetoAgenda.variableGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)

        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_usuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);" +
                    $"CREATE USER '(user_1)'@'%' IDENTIFIED BY '@senha';" +
                    $"GRANT privilégios ON  db_agenda.* TO 'user_1'@'%';";
                    
                
                


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

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
            catch(Exception erro)
            {
                MessageBox.Show($"erro ao efetuar o cadastro :{erro.Message}");

                return false;
            }

        }

        public bool LogarUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao();
                string sql = @"select usuario,nome,telefone from tb_usuarios
                            where usuario = @usuario
                        and Binary senha = @senha ;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    // caso o usuario consiga logar,preencho o User_session
                    // com as  suas informações 
                    User_session.usuario = resultado.GetString("usuario");
                    User_session._nome= resultado.GetString("_nome ");
                    User_session._senha = resultado.GetString("_senha ");
                    conexao.Close();
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
       
    }
  

}
