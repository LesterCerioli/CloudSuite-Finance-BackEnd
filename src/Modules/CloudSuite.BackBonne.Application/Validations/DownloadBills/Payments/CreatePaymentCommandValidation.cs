using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Payments
{
    public class CreatePaymentCommandValidation : AbstractValidator<CreatePaymentCommand>
    {
        public CreatePaymentCommandValidation()
        {
            RuleFor(a => a.Amount)
                .NotNull()
                .WithMessage("O campo é obrigatório.")
                .NotEmpty()
                .WithMessage("O campo não pode estar vazio.")
                .GreaterThan(0)
                .WithMessage("O valor pago deve ser maior ou igual a 0.");

            RuleFor(a => a.PaymentDate)
               .NotEmpty()
               .WithMessage("O campo é obrigatório.")
               .NotNull()
               .WithMessage("O campo não pode ser nulo")
               .GreaterThanOrEqualTo(DateTime.Now)
               .WithMessage("O campo ExpireTime deve ser uma data e hora no passado ou presente.");

            RuleFor(x => x.PaymentMethod)
                .IsInEnum()
                .NotNull()
                .WithMessage("O campo de Método de Pagamento é Obrigatório");
        }
    }
}
