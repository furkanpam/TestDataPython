using MediatR;
using System;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public interface ICommand : IRequest
    {
        Guid CommandId { get; }
    }
}
