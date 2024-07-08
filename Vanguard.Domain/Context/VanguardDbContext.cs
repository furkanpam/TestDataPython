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

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=10.240.1.210;Port=5000;Database=asis_postgres;User Id=developer;Password=d3v3l0p3r;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
