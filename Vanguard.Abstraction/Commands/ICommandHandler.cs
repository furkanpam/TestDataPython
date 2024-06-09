using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
        where TCommand : ICommand
    {
    }
}
