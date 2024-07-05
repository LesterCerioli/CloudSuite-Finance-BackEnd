using System.Linq;
using Microsoft.EntityFrameworkCore;
using FluentValidation.Results;
using CloudSuite.BackBonne.Infrastructure.Mapping;
using NetDevPack.Messaging;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.BackBonne.Infrastructure.Context
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Investment> Investments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                    e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new InvestmentEFCoreMapping());

            modelBuilder.Entity<Investment>(c =>
            {
                c.ToTable("msfinance_Investment");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
