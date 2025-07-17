using ControleDeFuncionarios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Repositories
{
    public interface IFuncionarioRepository
    {
        Task InserirFuncionarioAsync(Funcionario funcionario);
    }
}
