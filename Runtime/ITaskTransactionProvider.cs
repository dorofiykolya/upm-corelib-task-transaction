using Injections;

// ReSharper disable once CheckNamespace
namespace Framework.Runtime.TaskTransactions
{
    public interface ITaskTransactionProvider
    {
        IInjector Injector { get; }
    }
}