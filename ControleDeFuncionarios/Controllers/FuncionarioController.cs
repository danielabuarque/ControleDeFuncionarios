using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Controllers
{
    /// <summary>
    /// Controller para executar operações de funcionário com usuário final
    /// </summary>
    public class FuncionarioController
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IEmpresaRepository _empresaRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository, IEmpresaRepository empresaRepository)
        {
            _funcionarioRepository=funcionarioRepository;
            _empresaRepository = empresaRepository;
        }

        public async Task CadastrarFuncionarioAsync()
        {
            #region Consultar as empresas cadastradas no banco de dados

            var empresas = await _empresaRepository.ObterEmpresasAsync();

            foreach (var emp in empresas)
            {
                Console.WriteLine($"ID: {emp.Id}, RAZÃO SOCIAL: {emp.RazaoSocial}, CNPJ: {emp.Cnpj}");

            }

            #endregion

            #region Inserindo um funcionário no banco de dados

            var funcionario = new Funcionario();

            Console.WriteLine("\n - CADASTRO DE FUNCIONÁRIO: - \n");

            Console.Write("NOME DO FUNCIONÁRIO...: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("CPF...................: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("MATRICULA.............: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("DATA DE ADMISSÃO......: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("ID DA EMPRESA.........: ");
            funcionario.EmpresaId = Guid.Parse(Console.ReadLine());

            await _funcionarioRepository.InserirFuncionarioAsync(funcionario);

            Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!");

            #endregion
        }
    }
}
