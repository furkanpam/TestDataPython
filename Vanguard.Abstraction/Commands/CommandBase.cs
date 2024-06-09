using System;

namespace Asis.RotaPay.Abstraction.Abstraction.Commands
{
    public abstract class CommandBase : ICommand
    {
        protected CommandBase()
        {
            this.CommandId = Guid.NewGuid();
        }

        protected CommandBase(Guid id)
        {
            this.CommandId = id;
        }

        public Guid CommandId { get; }
    }
}
