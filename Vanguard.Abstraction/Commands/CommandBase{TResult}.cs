using System;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public abstract class CommandBase<TResult> : ICommand<TResult>
    {
        protected CommandBase()
        {
            this.CommandId = Guid.NewGuid();
        }

        protected CommandBase(Guid commandId)
        {
            this.CommandId = commandId;
        }

        public Guid CommandId { get; }
    }
}
