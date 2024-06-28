
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim;
using FluentValidation;


namespace CloudSuite.BackBonne.Application.Validations.UserClaim
{
    public class CreateUserClaimValidation : AbstractValidator<CreateUserClaimCommand>
    {
        public CreateUserClaimValidation()
        {
            RuleFor(x => x.Type)
                .NotEmpty()
                .WithMessage("O campo 'Type' é obrigatório.")
                .Length(1, 50)
                .WithMessage("O campo 'Type' deve ter entre 1 e 50 caracteres.")
                .NotNull()
                .WithMessage("O campo 'Type' não pode ser nulo.");

            RuleFor(x => x.Value)
                .NotEmpty()
                .WithMessage("O campo 'Value' é obrigatório.")
                .Length(1, 100)
                .WithMessage("O campo 'Value' deve ter entre 1 e 100 caracteres.")
                .NotNull()
                .WithMessage("O campo 'Value' não pode ser nulo.");
        }
    }
}
