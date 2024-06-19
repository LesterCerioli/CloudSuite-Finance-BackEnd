using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests
{
    public class CheckInvoiceExistsByPaymentDateRequest : IRequest<CheckInvoiceExistsPaymentDateResponse>
    {
        public Guid Id { get; private set; }
        
        public DateTimeOffset PaymentDate { get; private set; }

        public CheckInvoiceExistsByPaymentDateRequest(DateTimeOffset paymentDate)
        {
            Íd = Guid.NewGuid();
            PaymentDate = paymentDate;
        }
    }
}
