using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Interfaces;
using Dapper;
using System.Data;

namespace ControleDeFuncionarios.Repositories
{
    /// <summary>
    /// Repositório para operações de banco de dados com a entidade Funcionario.
    /// </summary>
    public class FuncionarioRepository: IFuncionarioRepository
    {
        private readonly IDbConnection _connection;

        public FuncionarioRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task InserirFuncionarioAsync(Funcionario funcionario)
        {
            var query = @"
                        INSERT INTO FUNCIONARIO (ID, NOME, CPF, MATRICULA, DATA_ADMISSAO, EMPRESA_ID) 
                        VALUES (@Id, @Nome, @Cpf, @Matricula, @DataAdmissao, @EmpresaId)
                        ";

            await _connection.ExecuteAsync(query, funcionario);
        }
    }
}
