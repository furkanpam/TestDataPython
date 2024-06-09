using Vanguard.Abstraction.Data.EfCore.UnitOfwork;
using Vanguard.Domain.Context;

namespace Vanguard.Infrastructre.UnitOfWork
{
    public interface IVanguardUnitOfWork : IUnitOfWork<VanguardDbContext>
    {
    }
}
