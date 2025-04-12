using System.Data.SqlClient;

namespace CadastroData.DAO
{
    internal class sqlConnection
    {
        public string ConnectionString { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SqlConnection(sqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}