using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses;
using MediatR;
using AsgardGoldUserEntity = CloudSuite.BackBonne.Domain.models.AsgardGold.AsgardGoldUser;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser
{
    public class CreateAsgardGoldUserCommand : IRequest<CreateAsgardGoldUserResponse>
    {
        public CreateAsgardGoldUserCommand(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }       

        public string? Email { get;  set; }

        public string? PasswordHash { get;  set; }

        public AsgardGoldUserEntity GetEntity()
        {
            return new AsgardGoldUserEntity(
                this.Email,
                this.PasswordHash
                );
        }
    }
}
