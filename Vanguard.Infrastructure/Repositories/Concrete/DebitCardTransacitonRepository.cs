﻿using Vanguard.Core.Data;
using Vanguard.Domain.Context;
using Vanguard.Domain.Entities;
using Vanguard.Infrastructure.Repositories.Abstract;

namespace Vanguard.Infrastructure.Repositories.Concrete
{
    public class DebitCardTransacitonRepository : EntityRepository<DebitCardTransaciton>, IDebitCardTransactionRepository
    {
        public DebitCardTransacitonRepository(VanguardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
