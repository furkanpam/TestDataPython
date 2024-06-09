using MediatR;
using System;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid CommandId { get; }
    }
}
