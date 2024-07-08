using Vanguard.Core.Data;
using Vanguard.Domain.Context;
using Vanguard.Domain.Entities;
using Vanguard.Infrastructure.Repositories.Abstract;

namespace Vanguard.Infrastructure.Repositories.Concrete
{
    public class DebitCardRepository : EntityRepository<DebitCard>, IDebitCardRepository
    {
        public DebitCardRepository(VanguardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
