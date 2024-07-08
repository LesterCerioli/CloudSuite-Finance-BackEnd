using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService;
using CloudSuite.BackBonne.Application.ViewModels;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.BackBonne.Application.Services.Contracts
{
    public interface IInvestmentAppService
    {
        Task<InvestmentViewModel> GetByTaxPayerRegistry(string taxPayerRegistry);

        Task<InvestmentViewModel> GetByName(string name);

        Task<InvestmentViewModel> GetByInvestmentProfile(string investmentProfile);

        Task Save(CreateInvestmentCommand createCommand);
    }
}