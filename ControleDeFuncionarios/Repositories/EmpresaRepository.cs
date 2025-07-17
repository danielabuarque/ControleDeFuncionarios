using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControleDeFuncionarios.Repositories
{
    /// <summary>
    /// Repositório para operação de banco de dados com a entidade Empresa.
    /// </summary>
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IDbConnection _connection;

        public EmpresaRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Empresa>> ObterEmpresasAsync()
        {
            //Escrevendo a consulta que será executada no banco de dados
            var query = @"
                        SELECT ID, RAZAOSOCIAL, CNPJ
                        FROM EMPRESA
                        ORDER BY RAZAOSOCIAL
                        ";

            var resultado = await _connection.QueryAsync<Empresa>(query);
            return resultado.ToList();
                
        }
    }
}
