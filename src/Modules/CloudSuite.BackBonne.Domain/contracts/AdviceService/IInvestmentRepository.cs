using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.BackBonne.Domain.contracts.AdviceService
{
    public interface IInvestmentRepository 
    {
        Task<Investment> GetByTaxPayerRegistry(string taxPayerRegistry);

        Task<Investment> GetByName(string name);

        Task<Investment> GetByInvestmentProfile(string investmentProfile);

        Task<IEnumerable<Investment>> GetList();

        Task Add(Investment investment);

        void Update(Investment investment);
        
        void Remove(Investment investment);
    }
}