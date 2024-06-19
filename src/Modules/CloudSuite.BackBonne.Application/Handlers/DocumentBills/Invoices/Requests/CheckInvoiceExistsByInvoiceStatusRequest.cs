using CloudSuite.Modules.Commons.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests
{
    public class CheckInvoiceExistsByInvoiceStatusRequest
    {
        public Guid Id { get; private set; }

        public InvoiceStatus InvoiceStatus {  get; private set; }

        public CheckInvoiceExistsByInvoiceStatusRequest(InvoiceStatus invoiceStatus)
        {
            Id = Guid.NewGuid();
            InvoiceStatus = invoiceStatus;
        }
    }
}
