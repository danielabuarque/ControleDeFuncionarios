using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Repositories;
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
        public void CadastrarFuncionario()
        {
            #region Consultar as empresas cadastradas no banco de dados

            var empresaRepository = new EmpresaRepository();
            var empresas = empresaRepository.ObterEmpresas();

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

            var funcionarioRepositorio = new FuncionarioRepository();
            funcionarioRepositorio.InserirFuncionario(funcionario);

            Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!");

            #endregion
        }
    }
}
