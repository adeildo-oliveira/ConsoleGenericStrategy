using ConsoleGenericStrategy.Entities;
using System;

namespace ConsoleGenericStrategy.Services.GenericStrategy
{
    public class ClienteAlteracao : IAlteracao<Cliente>
    {
        public bool PossuiAlteracao(Cliente response)
        {
            Console.WriteLine("Cliente alteração");
            return true;
        }
    }
}
