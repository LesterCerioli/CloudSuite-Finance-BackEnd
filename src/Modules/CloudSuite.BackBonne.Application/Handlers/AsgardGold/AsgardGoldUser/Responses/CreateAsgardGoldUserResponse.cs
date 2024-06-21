
using CloudSuite.BackBonne.Application;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses
{
    public class CreateAsgardGoldUserResponse : Response
    {
        public Guid RequestId { get; private set; }

        public CreateAsgardGoldUserResponse(Guid requestId, ValidationResult result)
        {
            RequestId = requestId;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CreateAsgardGoldUserResponse(Guid requestId, string failValidation)
        {
            RequestId = requestId;
            this.AddError(failValidation);
        }

    }
}

