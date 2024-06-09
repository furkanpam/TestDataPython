using Amazon.Runtime;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Abstraction.Consts;
using Vanguard.Abstraction.Data.Context;

namespace Vanguard.Domain.Context
{
    public partial class VanguardDbContext :DbContextBase
    {
        public VanguardDbContext()
        {
                
        }
        public VanguardDbContext([NotNull] DbContextOptions<VanguardDbContext> options) : base(options)
        {

        }

        #region DbSet
     
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Vanguard;User ID=user;Password=1234;MultipleActiveResultSets=true;TrustServerCertificate=true;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
