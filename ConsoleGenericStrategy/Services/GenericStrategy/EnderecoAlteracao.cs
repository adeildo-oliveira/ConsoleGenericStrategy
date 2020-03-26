using ConsoleGenericStrategy.Entities;
using System;

namespace ConsoleGenericStrategy.Services.GenericStrategy
{
    public class EnderecoAlteracao : IAlteracao<Endereco>
    {
        public bool PossuiAlteracao(Endereco request)
        {
            Console.WriteLine("Endereço alteração");
            return true;
        }
    }
}
