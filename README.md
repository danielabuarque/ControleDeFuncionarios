# 🏢 ControleDeFuncionarios - Sistema de Gestão de Funcionários

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

Console application desenvolvido em C# com arquitetura em camadas para gestão de empresas e funcionários.

## 🌿 Estrutura do Projeto

### 📂 **Raiz do Projeto**  
`📁 ControleDeFuncionarios/`  
`📄 ControleDeFuncionarios.sln` *(Arquivo Solution)*  
`📄 Script-Criação das Tabelas.sql` *(Script do banco de dados)*  

---

### 🧩 **Camadas da Aplicação**

#### 🏗️ **Core (Núcleo)**
- `📁 Entities/` *(Modelos de domínio)*  
  - `📄 Empresa.cs` → Modelo de empresa (CNPJ, Razão Social, etc.)  
  - `📄 Funcionario.cs` → Modelo de funcionário (CPF, Cargo, Salário, etc.)  

#### 🔌 **Abstrações**
- `📁 Interfaces/` *(Contratos)*  
  - `📄 IEmpresaRepository.cs` → Operações para Empresa (CRUD)  
  - `📄 IFuncionarioRepository.cs` → Operações para Funcionário  

#### 🗃️ **Infraestrutura**
- `📁 Repositories/` *(Acesso a dados)*  
  - `📄 EmpresaRepository.cs` → Implementação concreta para Empresa  
  - `📄 FuncionarioRepository.cs` → Implementação para Funcionário  

#### 🎮 **Lógica de Negócio**
- `📁 Controllers/` *(Regras de aplicação)*  
  - `📄 EmpresaController.cs` → Validações e fluxos de empresa  
  - `📄 FuncionarioController.cs` → Regras de funcionários  
  - `🚦 Fluxo`: Orquestra as operações entre Repositórios e Entidades  

---


## 💻 Como Executar - Passo a Passo

```bash
# 1. Clone o repositório
git clone https://github.com/danielabuarque/ControleDeFuncionarios.git

# 2. Acesse o diretório do projeto
cd ControleDeFuncionarios

# 3. Restaure as dependências do NuGet
dotnet restore

# 4. Execute o script `Script-Criação das Tabelas.sql` no seu SQL Server
# (Use o SQL Server Management Studio ou outro cliente SQL)

# 5. Configure a connection string em `appsettings.json`:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=ControleFuncionarios;Trusted_Connection=True;"
  }
}
# 6. Execute a aplicação
dotnet run
