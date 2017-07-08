using System.Threading.Tasks;

namespace Fibon.Messages.Command
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }

    public class CalculateValueCommand : ICommand
    {
        public int Number { get;set; }
    }
}