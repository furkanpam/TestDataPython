using System.Threading.Tasks;
using Asis.RotaPay.Abstraction.Commands;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public interface ICommandSender
    {
        Task PublishAsync(ICommand command);
        Task<TResult> SendAsync<TResult>(ICommand<TResult> command);

        Task SendAsync(ICommand command);
        Task<IEnumerable<TResult>> SendAsync<TResult>(IEnumerable<ICommand<TResult>> commands);
        Task SendForMqAsync(ICommand command);
        void SendToErrorMQ(MQCommandModel command, string message);

        //void SendToMQ<TResult>(ICommand<TResult> command);
        void SendToMQ(ICommand command);
        Task SendToMQAsync(params ICommand[] command);
        void SendToMQForModeMng(ICommand command);
    }
}
