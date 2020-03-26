using ConsoleGenericStrategy.Entities;
using System;

namespace ConsoleGenericStrategy.Services.GenericStrategy
{
    public class TipoProduto : IAlteracao<Produto>
    {
        public bool PossuiAlteracao(Produto request)
        {
            Console.WriteLine("Tipo produto alteração");
            return true;
        }
    }
}
