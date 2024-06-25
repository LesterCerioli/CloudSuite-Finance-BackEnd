using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Invoices
{
    public class CheckInvoiceExistsByAmountRequestValidation : AbstractValidator<CheckInvoiceExistsByAmountRequest>
    {
        public CheckInvoiceExistsByAmountRequestValidation()
        {
            RuleFor(i => i.Amount)
                .NotNull()
                .WithMessage("O campo é obrigatório.")
                .NotEmpty()
                .WithMessage("O campo não pode estar vazio.")
                .GreaterThan(0)
                .WithMessage("O valor pago deve ser maior ou igual a 0.");
        }
    }
}
