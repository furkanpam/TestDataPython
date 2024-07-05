using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Vanguard.Abstraction.Data.Context;
using Vanguard.Domain.Entities;

namespace Vanguard.Domain.Context
{
    public partial class VanguardDbContext : DbContextBase
    {
        public VanguardDbContext()
        {

        }
        public VanguardDbContext([NotNull] DbContextOptions<VanguardDbContext> options) : base(options)
        {

        }

        #region DbSet
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Identifier> Identifiers { get; set; }
     //   public virtual DbSet<Account> Accounts { get; set; }
       // public virtual DbSet<Account> Accounts { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=.;Database=Vanguard;User ID=user;Password=1234;MultipleActiveResultSets=true;TrustServerCertificate=true;");
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
