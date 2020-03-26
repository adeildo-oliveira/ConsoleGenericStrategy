using ConsoleGenericStrategy.Entities;
using ConsoleGenericStrategy.Services;
using ConsoleGenericStrategy.Services.GenericStrategy;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace ConsoleGenericStrategy.Tests
{
    public class ProgramIntegrationTests
    {
        private readonly IServiceProvider serviceProvider;

        public ProgramIntegrationTests()
        {
            serviceProvider = new ServiceCollection()
                        .AddScoped<IAlteracao<Produto>, TipoProduto>()
                        .AddScoped<IAlteracao<Telefone>, TelefoneAlteracao>()
                        .AddScoped<IAlteracao<Endereco>, EnderecoAlteracao>()
                        .AddScoped<IAlteracao<Cliente>, ClienteAlteracao>()
                        .AddScoped<IInvokingStrategy, InvokingStrategy>()
                        .BuildServiceProvider();
        }

        [Fact]
        public void DeveRetornarVeradeiroQuandoExecutadoTodosEstrategys()
        {
            var service = serviceProvider.GetService<IInvokingStrategy>();
            service.PossuiAlteracao(new Cliente()).Should().BeTrue();
            service.PossuiAlteracao(new Endereco()).Should().BeTrue();
            service.PossuiAlteracao(new Telefone()).Should().BeTrue();
            service.PossuiAlteracao(new Produto()).Should().BeTrue();
        }
    }
}
