using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses;
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Request
{
    public class CheckUserClaimByTypeRequest : IRequest<CheckUserClaimByTypeResponse>
    {
        public CheckUserClaimByTypeRequest(string? type)
        {
            Id = Guid.NewGuid();
            Type = type;
        }

        public Guid Id { get; private set; }

        public string? Type { get; set; }
    }
}
