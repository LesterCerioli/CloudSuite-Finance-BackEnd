using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudSuite.Infrastructure.Context;
using CloudSuite.BackBonne.Domain.contracts.AdviceService;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.Infrastructure.Repositories
{
    public class InvestmentRepository : IInvestmentRepository
    {
        protected readonly FinanceDbContext Db;
        protected readonly DbSet<Investment> DbSet;

        public InvestmentRepository(FinanceDbContext context)
        {
            Db = context;
            DbSet = context.Investments;
        }

        public async Task Add(Investment investment)
        {
            await DbSet.AddAsync(investment);
            await Db.SaveChangesAsync();
        }

        public async Task<Investment> GetByTaxPayerRegistry(string taxPayerRegistry)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.TaxPayerRegistry == taxPayerRegistry);
        }

        public async Task<Investment> GetByName(string name)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<Investment> GetByInvestmentProfile(string investmentProfile)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.InvestmentProfile == investmentProfile);
        }

        public async Task<IEnumerable<Investment>> GetList()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public void Remove(Investment investment)
        {
            DbSet.Remove(investment);
        }

        public void Update(Investment investment)
        {
            DbSet.Update(investment);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
