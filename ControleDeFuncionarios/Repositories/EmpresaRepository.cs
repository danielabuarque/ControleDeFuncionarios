using ControleDeFuncionarios.Configurations;
using ControleDeFuncionarios.Entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleDeFuncionarios.Repositories
{
    /// <summary>
    /// Repositório para operação de banco de dados com a entidade Empresa.
    /// </summary>
    public class EmpresaRepository
    {
        public List<Empresa> ObterEmpresas()
        {
            //Escrevendo a consulta que será executada no banco de dados
            var query = @"
                        SELECT ID, RAZAO_SOCIAL, CNPJ
                        FROM EMPRESA
                        ORDER BY RAZAO_SOCIAL
                        ";

            //Criando um objeto da classe de configuração
            var config = new DBConfiguration();

            //Abrindo conexão com o banco de dados
            using (var connection = new SqlConnection(config.ConnectionString))
            {
                return connection.Query<Empresa>(query).ToList();
            }
                
        }
    }
}
