using ConsoleGenericStrategy.Entities;
using System;

namespace ConsoleGenericStrategy.Services.GenericStrategy
{
    public class TelefoneAlteracao : IAlteracao<Telefone>
    {
        public bool PossuiAlteracao(Telefone request)
        {
            Console.WriteLine("Telefone alteração");
            return true;
        }
    }
}
