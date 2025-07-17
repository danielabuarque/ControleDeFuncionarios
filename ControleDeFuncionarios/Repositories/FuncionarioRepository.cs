using ControleDeFuncionarios.Configurations;
using ControleDeFuncionarios.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var config = new DBConfiguration();

            await _connection.ExecuteAsync(query, funcionario);
        }
    }
}
