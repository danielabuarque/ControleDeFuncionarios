using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Configurations
{
    /// <summary>
    /// Classe para armazenar as configurações de acesso ao banco de dados
    /// </summary>
    public class DBConfiguration
    {
        public string ConnectionString 
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBFuncionarios;Integrated Security=True;";
            }
            
        }
    }
}
