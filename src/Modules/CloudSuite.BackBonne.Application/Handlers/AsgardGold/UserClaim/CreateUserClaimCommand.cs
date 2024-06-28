using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Responses;
using MediatR;
using UserClaimEntity = CloudSuite.BackBonne.Domain.models.AsgardGold.UserClaim;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim
{
    public class CreateUserClaimCommand : IRequest<CreateUserClaimResponse>
    {
        public CreateUserClaimCommand(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string? Type { get; set; }

        public string? Value { get; set; }

        public UserClaimEntity GetEntity()
        {
            return new UserClaimEntity(
                this.Type,
                this.Value

            );
        }
    }
}
