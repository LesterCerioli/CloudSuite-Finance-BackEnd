using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Request;
using FluentValidation;


namespace CloudSuite.BackBonne.Application.Validations.UserClaim
{
    public class CheckUserClaimByTypeValidation : AbstractValidator<CheckUserClaimByTypeRequest>
    {
        public CheckUserClaimByTypeValidation()
        {
            RuleFor(x => x.Type)
                .NotEmpty()
                .WithMessage("O campo 'Type' é obrigatório.")
                .Length(1, 50)
                .WithMessage("O campo 'Type' deve ter entre 1 e 50 caracteres.")
                .NotNull()
                .WithMessage("O campo 'Type' não pode ser nulo.");
        }
    }
}
