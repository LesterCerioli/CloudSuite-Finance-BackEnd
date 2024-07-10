using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests
{
    public class CheckExistsInvestmentByNameRequest : IRequest<CheckExistsInvestmentByNameResponse>
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public CheckExistsInvestmentByNameRequest(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
