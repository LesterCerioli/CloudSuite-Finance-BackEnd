using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests
{
    public class CheckExistsInvestmentByInvestmentProfileRequest : IRequest<CheckExistsInvestmentByInvestmentProfileResponse>
    {
        public Guid Id { get; private set; }

        public string InvestmentProfile { get; private set; }

        public CheckExistsInvestmentByInvestmentProfileRequest(string investmentProfile)
        {
            Id = Guid.NewGuid();
            InvestmentProfile = investmentProfile;
        }
    }
}
