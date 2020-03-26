using ConsoleGenericStrategy.Entities;
using ConsoleGenericStrategy.Services;
using ConsoleGenericStrategy.Services.GenericStrategy;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using System;
using Xunit;

namespace ConsoleGenericStrategy.Tests
{
    public class InvokingStrategyTests
    {
        private readonly AutoMocker _mocker;
        private readonly InvokingStrategy _invokingStrategy;
        private readonly Mock<IServiceProvider> _mockServiProvide;

        public InvokingStrategyTests()
        {
            _mocker = new AutoMocker();
            _mockServiProvide = _mocker.GetMock<IServiceProvider>();
            _invokingStrategy = _mocker.CreateInstance<InvokingStrategy>();
        }

        [Fact]
        public void DeveRetornarVeradeiroParaClienteAlterado()
        {
            var cliente = new Cliente();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Cliente>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(cliente)).Returns(true);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Cliente>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(cliente);

            resultado.Should().BeTrue();
        }

        [Fact]
        public void DeveRetornarFalsoParaClienteNaoAlterado()
        {
            var cliente = new Cliente();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Cliente>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(cliente)).Returns(false);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Cliente>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(cliente);

            resultado.Should().BeFalse();
        }

        [Fact]
        public void DeveRetornarVeradeiroParaEnderecoAlterado()
        {
            var endereco = new Endereco();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Endereco>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(endereco)).Returns(true);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Endereco>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(endereco);

            resultado.Should().BeTrue();
        }

        [Fact]
        public void DeveRetornarFalsoParaEnderecoNaoAlterado()
        {
            var endereco = new Endereco();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Endereco>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(endereco)).Returns(false);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Endereco>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(endereco);

            resultado.Should().BeFalse();
        }

        [Fact]
        public void DeveRetornarVeradeiroParaTelefoneAlterado()
        {
            var telefone = new Telefone();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Telefone>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(telefone)).Returns(true);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Telefone>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(telefone);

            resultado.Should().BeTrue();
        }

        [Fact]
        public void DeveRetornarFalsoParaTelefoneNaoAlterado()
        {
            var telefone = new Telefone();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Telefone>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(telefone)).Returns(false);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Telefone>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(telefone);

            resultado.Should().BeFalse();
        }

        [Fact]
        public void DeveRetornarVeradeiroParaTipoProdutofoneAlterado()
        {
            var produto = new Produto();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Produto>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(produto)).Returns(true);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Produto>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(produto);

            resultado.Should().BeTrue();
        }

        [Fact]
        public void DeveRetornarFalsoParaTipoProdutoNaoAlterado()
        {
            var produto = new Produto();
            var _mockAlteracao = _mocker.GetMock<IAlteracao<Produto>>();
            _mockAlteracao.Setup(x => x.PossuiAlteracao(produto)).Returns(false);
            _mockServiProvide.Setup(x => x.GetService(typeof(IAlteracao<Produto>))).Returns(_mockAlteracao.Object);

            var resultado = _invokingStrategy.PossuiAlteracao(produto);

            resultado.Should().BeFalse();
        }
    }
}
