using ControleDeFuncionarios.Controllers;
using ControleDeFuncionarios.Interfaces;
using ControleDeFuncionarios.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

public class Program
{
    public static async Task Main(string[] args)
    {

        var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())  // raiz do projeto
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection");

        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
                {
                  services.AddTransient<IDbConnection>(sp => new SqlConnection(connectionString));
                  services.AddTransient<IEmpresaRepository, EmpresaRepository>();
                  services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
                  services.AddTransient<FuncionarioController>();                
                }).Build();

        // Aqui você resolve o controller pelo container de DI
        var controller = host.Services.GetRequiredService<FuncionarioController>();

        // E chama o método async dele usando await
        await controller.CadastrarFuncionarioAsync();

        Console.ReadKey();
    }
}



