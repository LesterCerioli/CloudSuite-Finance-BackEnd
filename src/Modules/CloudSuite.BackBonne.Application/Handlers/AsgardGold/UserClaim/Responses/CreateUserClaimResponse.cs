using CloudSuite.Modules.Cora.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Responses
{
    public class CreateUserClaimResponse : Response
    {
        public Guid RequestId { get; private set; }

        public CreateUserClaimResponse(Guid requestId, ValidationResult result)
        {
            RequestId = requestId;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CreateUserClaimResponse(Guid requestId, string failValidation)
        {
            RequestId = requestId;
            this.AddError(failValidation);
        }

    }
}
