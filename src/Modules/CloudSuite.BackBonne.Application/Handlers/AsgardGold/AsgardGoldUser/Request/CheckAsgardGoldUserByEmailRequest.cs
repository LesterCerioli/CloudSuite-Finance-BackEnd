using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses;
using MediatR;


namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Request
{
    public class CheckAsgardGoldUserByEmailRequest : IRequest<CheckAsgardGoldUserByEmailResponse>
    {
        public CheckAsgardGoldUserByEmailRequest(string? email)
        {
            Id = Guid.NewGuid(); 
            Email = email;
        }

        public Guid Id { get; private set; }

        public string? Email { get; set; }

    }
}
