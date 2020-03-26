using ConsoleGenericStrategy.Services.GenericStrategy;
using System;

namespace ConsoleGenericStrategy.Services
{
    public class InvokingStrategy : IInvokingStrategy
    {
        private readonly IServiceProvider _serviceProvider;
        public InvokingStrategy(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        public bool PossuiAlteracao<T>(T request)
        {
            var alteracao = (IAlteracao<T>)_serviceProvider.GetService(typeof(IAlteracao<T>));
            return alteracao.PossuiAlteracao(request);
        }
    }
}
