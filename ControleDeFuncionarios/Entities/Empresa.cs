using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Entities
{
    /// <summary>
    /// Modelo de domínio para empresa.
    /// </summary>
    public class Empresa
    {
        #region Propriedades
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        #endregion

        #region Relacionamentos
        List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        #endregion

    }
}
