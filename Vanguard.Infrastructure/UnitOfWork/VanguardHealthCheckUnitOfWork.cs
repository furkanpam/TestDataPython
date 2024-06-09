using Vanguard.Abstraction.Data.EfCore.UnitOfwork;
using Vanguard.Domain.Context;

namespace Vanguard.Infrastructre.UnitOfWork
{
    public interface VanguardHealthCheckUnitOfWork : IUnitOfWork<VanguardHealthCheckDbContext>
    {
    }
}
