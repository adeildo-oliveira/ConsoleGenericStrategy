namespace ConsoleGenericStrategy.Services
{
    public interface IInvokingStrategy
    {
        bool PossuiAlteracao<T>(T request);
    }
}
