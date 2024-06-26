using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.Modules.Commons.Enumerators;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests
{
    public class CheckInvoiceExistsByInvoiceStatusRequest : IRequest<CheckInvoiceExistsByInvoiceStatusResponse>
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
