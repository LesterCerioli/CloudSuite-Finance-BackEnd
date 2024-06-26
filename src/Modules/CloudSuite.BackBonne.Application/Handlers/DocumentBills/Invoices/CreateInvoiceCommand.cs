using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.Modules.Commons.Enumerators;
using MediatR;
using InvoiceEntity = CloudSuite.BackBonne.Domain.models.DownloadBills.Invoice;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CreateInvoiceCommand : IRequest<CreateInvoiceResponse>
    {
        public Guid Id { get; private set; }

        public decimal? Amount { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTimeOffset? PaymentDate { get; set; }

        public InvoiceStatus? InvoiceStatus { get; set; }

        public CreateInvoiceCommand()
        {
            Id = Guid.NewGuid();
        }

        public InvoiceEntity GetEntity()
        {
            return new InvoiceEntity(
                this.Amount,
                this.DueDate,
                this.PaymentDate,
                this.InvoiceStatus
                );
        }

    }
}
