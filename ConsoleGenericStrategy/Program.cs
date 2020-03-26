using ConsoleGenericStrategy.Entities;
using ConsoleGenericStrategy.Services;
using ConsoleGenericStrategy.Services.GenericStrategy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleGenericStrategy
{
    class Program
    {
        private static IServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            RegistreService();

            //SIMULANDO O CONSUMO VIA DEPENDENCY INJECTION
            var service = serviceProvider.GetService<IInvokingStrategy>();
            service.PossuiAlteracao(new Cliente());
            service.PossuiAlteracao(new Endereco());
            service.PossuiAlteracao(new Telefone());
            service.PossuiAlteracao(new Produto());
        }

        private static void RegistreService() => serviceProvider = new ServiceCollection()
                        .AddScoped<IAlteracao<Produto>, TipoProduto>()
                        .AddScoped<IAlteracao<Telefone>, TelefoneAlteracao>()
                        .AddScoped<IAlteracao<Endereco>, EnderecoAlteracao>()
                        .AddScoped<IAlteracao<Cliente>, ClienteAlteracao>()
                        .AddScoped<IInvokingStrategy, InvokingStrategy>()
                        .BuildServiceProvider();
    }
}
