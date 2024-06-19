using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests
{
    public class CheckInvoiceExistsByAmountRequest : IRequest<CheckInvoiceExistsByAmountResponse>
    {
        public Guid Id {  get; private set; }
        public decimal Amount {  get; private set; }

        public CheckInvoiceExistsByAmountRequest(decimal amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
        }
    }
}
