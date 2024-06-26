using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.Modules.Commons.Enumerators;
using MediatR;
using PaymentEntity = CloudSuite.BackBonne.Domain.models.DownloadBills.Payment;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments
{
    public class CreatePaymentCommand : IRequest<CreatePaymentResponse>
    {
        public Guid Id { get; private set; }

        public decimal? Amount { get; set; }

        public DateTime? PaymentDate { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }

        public CreatePaymentCommand()
        {
            Id = Guid.NewGuid();
        }

        public PaymentEntity GetEntity()
        {
            return new PaymentEntity(
                this.Amount,
                this.PaymentDate,
                this.PaymentMethod
                );
        }
    }
}
