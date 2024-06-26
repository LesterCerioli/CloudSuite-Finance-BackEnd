using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Invoices
{
    public class CheckInvoiceExistsByPaymentDateRequestValidation : AbstractValidator<CheckInvoiceExistsByPaymentDateRequest>
    {
        public CheckInvoiceExistsByPaymentDateRequestValidation()
        {
            RuleFor(a => a.PaymentDate)
                .NotEmpty()
                .WithMessage("O campo é obrigatório.")
                .NotNull()
                .WithMessage("O campo não pode ser nulo")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("O campo PaymentDate deve ser uma data e hora no passado ou presente.");
        }
    }
}
