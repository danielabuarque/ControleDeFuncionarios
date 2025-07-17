using ControleDeFuncionarios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Interfaces
{
    public interface IFuncionarioRepository
    {
        Task InserirFuncionarioAsync(Funcionario funcionario);
    }
}
