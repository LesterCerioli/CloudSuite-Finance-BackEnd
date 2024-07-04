using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Invoices
{
    public class CheckInvoiceExistsByInvoiceStatusRequestValidation : AbstractValidator<CheckInvoiceExistsByInvoiceStatusRequest>
    {
        public CheckInvoiceExistsByInvoiceStatusRequestValidation()
        {
            RuleFor(i => i.InvoiceStatus)
                .IsInEnum()
                .NotNull()
                .WithMessage("O campo de Método de Pagamento é Obrigatório");
        }
    }
}
