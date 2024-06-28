using FluentValidation;
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser;
using System.ComponentModel.DataAnnotations;

namespace CloudSuite.BackBonne.Application.Validations.AsgardGold
{
    public class CreateAsgardGoldUserValidation : AbstractValidator<CreateAsgardGoldUserCommand>
    {
        public CreateAsgardGoldUserValidation()
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

            RuleFor(x => x.PasswordHash)
                .NotEmpty()
                .WithMessage("Senha é obrigatória.")
                .NotNull()
                .WithMessage("Senha não pode ser nula.")
                .MinimumLength(8)
                .WithMessage("A senha deve ter no mínimo 8 caracteres.")
                .Matches("[A-Z]")
                .WithMessage("A senha deve conter pelo menos uma letra maiúscula.")
                .Matches("[a-z]")
                .WithMessage("A senha deve conter pelo menos uma letra minúscula.")
                .Matches("[0-9]")
                .WithMessage("A senha deve conter pelo menos um número.")
                .Matches("[^a-zA-Z0-9]")
                .WithMessage("A senha deve conter pelo menos um caractere especial.");
        }
    }
}

