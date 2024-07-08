using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using MediatR;
using InvestmentEntity = CloudSuite.BackBonne.Domain.models.AdviceService.Investment;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService
{
    public class CreateInvestmentCommand : IRequest<CreateInvestmentResponse>
    {
        public Guid Id { get; private set; }

        public string? TaxPayerRegistry { get; set; }

        public string? Name { get; set; }

        public string? InvestmentProfile { get; set; }

        public CreateInvestmentCommand()
        {
            Id = Guid.NewGuid();
        }

        public InvestmentEntity GetEntity()
        {
            return new InvestmentEntity(
                this.TaxPayerRegistry,
                this.Name,
                this.InvestmentProfile
                );

        }
    }
}
