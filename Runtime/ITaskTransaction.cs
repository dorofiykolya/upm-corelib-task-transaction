using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Framework.Runtime.TaskTransactions
{
    public interface ITaskTransaction
    {
        void Execute(ITaskContext context);
        void Undo();
    }
}