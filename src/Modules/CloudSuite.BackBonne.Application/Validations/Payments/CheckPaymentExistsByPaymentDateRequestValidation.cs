using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Payments
{
    public class CheckPaymentExistsByPaymentDateRequestValidation : AbstractValidator<CheckPaymentExistsByPaymentDateRequest>
    {
        public CheckPaymentExistsByPaymentDateRequestValidation()
        {
            RuleFor(p => p.PaymentDate)
               .NotEmpty()
               .WithMessage("O campo é obrigatório.")
               .NotNull()
               .WithMessage("O campo não pode ser nulo")
               .GreaterThanOrEqualTo(DateTime.Now)
               .WithMessage("O campo ExpireTime deve ser uma data e hora no passado ou presente.");
        }
    }
}
