namespace ConsoleGenericStrategy.Services.GenericStrategy
{
    public interface IAlteracao<TRequest>
    {
        bool PossuiAlteracao(TRequest request);
    }
}
