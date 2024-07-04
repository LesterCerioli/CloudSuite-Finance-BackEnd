using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Payments
{
    public class CheckPaymentExistsByAmountRequestValidation : AbstractValidator<CheckPaymentExistsByAmountRequest>
    {
        public CheckPaymentExistsByAmountRequestValidation()
        {
            RuleFor(a => a.Amount)
                .NotNull()
                .WithMessage("O campo é obrigatório.")
                .NotEmpty()
                .WithMessage("O campo não pode estar vazio.")
                .GreaterThan(0)
                .WithMessage("O valor pago deve ser maior ou igual a 0.");
                
        }
    }
}
