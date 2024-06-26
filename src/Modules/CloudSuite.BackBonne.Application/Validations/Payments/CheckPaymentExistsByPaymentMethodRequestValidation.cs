using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Payments
{
    public class CheckPaymentExistsByPaymentMethodRequestValidation : AbstractValidator<CheckPaymentExistsByPaymentMethodRequest>
    {
        public CheckPaymentExistsByPaymentMethodRequestValidation()
        {
            RuleFor(x => x.PaymentMethod)
                .IsInEnum()
                .NotNull()
                .WithMessage("O campo de Método de Pagamento é Obrigatório");
        }
    }
}
