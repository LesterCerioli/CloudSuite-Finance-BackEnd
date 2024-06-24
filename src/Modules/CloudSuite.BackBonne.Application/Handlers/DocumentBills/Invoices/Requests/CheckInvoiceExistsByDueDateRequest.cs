using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests
{
    public class CheckInvoiceExistsByDueDateRequest : IRequest<CheckInvoiceExistsByDueDateResponse>
    {
        public Guid Id { get; private set; }

        public DateTime DueDate { get; private set; }

        public CheckInvoiceExistsByDueDateRequest(DateTime dueDate)
        {
            Id = Guid.NewGuid();
            DueDate = dueDate;
        }
    }
}
