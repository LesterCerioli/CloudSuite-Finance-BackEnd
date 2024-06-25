using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests
{
    public class CheckPaymentExistsByPaymentDateRequest : IRequest<CheckPaymentExistsByPaymentDateResponse>
    {
        public Guid Id { get; private set; }

        public DateTime PaymentDate { get; set; }

        public CheckPaymentExistsByPaymentDateRequest(DateTime paymentDate)
        {
            Id = Guid.NewGuid();
            PaymentDate = paymentDate;
        }
    }
}
