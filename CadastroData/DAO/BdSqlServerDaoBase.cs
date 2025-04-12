namespace CadastroData.DAO
{
    public class BdSqlServerDaoBase
    {
        [Obsolete]
        public void IncluiCliente(Cliente cliente)
        {
            // Instanciando a conexão
            sqlConnection conexao = new sqlConnection();
            // configurando conexão
            conexao.ConnectionString = conexaoSqlServer

        }

        public void IncluiCliente(global::CadastroWebApp.Controllers.Cliente clienteDTO)
        {
            if (clienteDTO is null)
            {
                throw new ArgumentNullException(nameof(clienteDTO));
            }

            throw new NotImplementedException();
        }
    }
}