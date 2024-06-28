
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Request;
using FluentValidation;


namespace CloudSuite.BackBonne.Application.Validations.AsgardGold
{
    public class CheckAsgardGoldUserByEmailValidation : AbstractValidator<CheckAsgardGoldUserByEmailRequest>
    {
        public CheckAsgardGoldUserByEmailValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O campo de e-mail é obrigatório.")
                .EmailAddress()
                .WithMessage("O campo de e-mail deve ser um endereço de e-mail válido.")
                .Length(1, 100)
                .WithMessage("O campo de e-mail deve ter entre 1 e 100 caracteres.")
                .NotNull()
                .WithMessage("O campo de e-mail não pode ser nulo.");
        }
    }
}
