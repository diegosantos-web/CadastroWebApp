using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroData.DAO
{
    public class ClienteDao : BdSqlServerDao
    {
        [Obsolete]
        public void IncluiCliente(Cliente cliente)
        {
            // instanciando conexão
            sqlConnection conexao = new SqlConection();

            // Configurar a conexão
            conexao.ConnectionString = conexaoSqlServer;

            // Instaciar o comando
            SqlCommand comando = new SqlCommand();

            string sql = "Insert into" +
                "cliente(Empresa, Endereço, Telefone)" +
                "Values (@Empresa, @Endereço, @Telefone);";

            comando.CommandText = sql;

            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.AddWithValue("@Empresa", cliente.Empresa);
            comando.Parameters.AddWithValue("@Endereço", cliente.Endereco);
            comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            comando.Connection = conexao;

            try
            {
                // Abre conexão
                conexao.Open();
                // Executa o comando
                comando.ExecuteNonQuery();

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

            finally
            {
                conexao.Open();
            }



        }


        public void AlterarCliente(Cliente cliente)
        {
            // instanciando conexão
            sqlConnection conexao = new SqlConection();

            // Configurar a conexão
            conexao.ConnectionString = conexaoSqlServer;

            // Instaciar o comando
            SqlCommand comando = new SqlCommand();

            string sql = "Update Cliente set " +
                "Empresa = @Empresa, Endereço = @Endereço, Telefone = @Telefone " +
                "where ClienteId = @ClienteId";

            comando.CommandText = sql;

            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.AddWithValue("@Empresa", cliente.Empresa);
            comando.Parameters.AddWithValue("@Endereço", cliente.Endereco);
            comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            comando.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);

            comando.Connection = conexao;

            try
            {
                // Abre conexão
                conexao.Open();

                // Executa o comando
                comando.ExecuteNonQuery();

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

            finally
            {
                conexao.Open();
            }



        }

        public void ExcluirCliente(int clienteId)
        {
            // instanciando conexão
            sqlConnection conexao = new SqlConection();

            // Configurar a conexão
            conexao.ConnectionString = conexaoSqlServer;

            // Instaciar o comando
            SqlCommand comando = new SqlCommand();

            string sql = "Delete From Cliente " +
                "where ClienteId = @ClienteId";

            comando.CommandText = sql;

            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.AddWithValue("@ClienteId", clienteId);

            comando.Connection = conexao;

            try
            {
                // Abre conexão
                conexao.Open();
                // Executa o comando
                comando.ExecuteNonQuery();

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

            finally
            {
                conexao.Open();
            }



        }

        public Cliente ObtemCliente(int clienteId)
        {
            // instanciando conexão
            sqlConnection conexao = new SqlConection();

            // Configurar a conexão
            conexao.ConnectionString = conexaoSqlServer;

            // Instaciar o comando
            SqlCommand comando = new SqlCommand();

            string sql = "Select * From Cliente " +
                "where ClienteId = @ClienteId";

            comando.CommandText = sql;

            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.AddWithValue("@ClienteId", clienteId);

            comando.Connection = conexao;

            try
            {
                // Abre conexão
                conexao.Open();

                // Executa o Comando
                SqlDataReader tabela = comando.ExecuteReader();

                if (tabela.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ClienteId = int.Parse( tabela["ClienteId"].ToString());
                    cliente.Empresa = tabela["Empresa"].ToString();
                    cliente.Endereço = tabela["Endereço"].ToString();
                    cliente.Telefone = tabela["Telefone"].ToString();
                    return cliente;
                }
                return null;

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

            finally
            {
                conexao.Open();
            }



        }


        public List<Cliente> ListaCliente()
        {
            // instanciando conexão
            sqlConnection conexao = new SqlConection();

            // Configurar a conexão
            conexao.ConnectionString = conexaoSqlServer;

            // Instaciar o comando
            SqlCommand comando = new SqlCommand();

            string sql = "Select * From Cadastro; ";
                
            comando.CommandText = sql;

            comando.CommandType = System.Data.CommandType.Text;

          

            comando.Connection = conexao;

            try
            {
                // Abre conexão
                conexao.Open();

                // Executa o Comando
                SqlDataReader tabela = comando.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();
                while (tabela.HasRows)
                {

                    while (tabela.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.ClienteId = int.Parse(tabela["ClienteId"].ToString());
                        cliente.Empresa = tabela["Empresa"].ToString();
                        cliente.Endereço = tabela["Endereço"].ToString();
                        cliente.Telefone = tabela["Telefone"].ToString();

                        lista.Add(cliente);
                    }
                    return lista;
                }

                return null;

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

            finally
            {
                conexao.Open();
            }



        }
    }
}
