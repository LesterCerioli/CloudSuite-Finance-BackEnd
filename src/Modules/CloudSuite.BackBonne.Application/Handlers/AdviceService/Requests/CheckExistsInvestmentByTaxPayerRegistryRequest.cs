using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests
{
    public class CheckExistsInvestmentByTaxPayerRegistryRequest : IRequest<CheckExistsInvestmentByTaxPayerRegistryResponse>
    {
        public Guid Id { get; private set; }

        public string TaxPayerRegistry { get; private set; }

        public CheckExistsInvestmentByTaxPayerRegistryRequest(string taxPayerRegistry)
        {
            Id = Guid.NewGuid();
            TaxPayerRegistry = taxPayerRegistry;
        }
    }
}
