using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Invoices
{
    public class CheckInvoiceExistsByDueDateRequestValidation : AbstractValidator<CheckInvoiceExistsByDueDateRequest>
    {
        public CheckInvoiceExistsByDueDateRequestValidation()
        {
            RuleFor(i => i.DueDate)
               .GreaterThanOrEqualTo(DateTime.Now)
               .WithMessage("O campo ExpireDate deve ser uma data futura ou presente.");
        }
    }
}
