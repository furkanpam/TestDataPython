using MediatR;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : ICommand<TResult>
    {
    }
}
