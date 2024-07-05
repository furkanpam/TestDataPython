using Vanguard.Core.Data;
using Vanguard.Domain.Context;
using Vanguard.Domain.Entities;
using Vanguard.Infrastructure.Repositories.Abstract;

namespace Vanguard.Infrastructure.Repositories.Concrete
{
    public class AccountRepository : EntityRepository<Account>, IAccountRepository
    {
        public AccountRepository(VanguardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
