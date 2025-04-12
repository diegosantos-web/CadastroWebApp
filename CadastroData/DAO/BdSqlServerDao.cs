using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroData.DAO
{
    public class BdSqlServerDao : BdSqlServerDaoBase
    {
        //Configuração do banco de dados
        public readonly string conexaoSqlServer = @"Data Source=SANTOS\DIEGOSANTOS;" +
            "Database=Cadastro;" +
            "Integrated Security=True";
    }
}
