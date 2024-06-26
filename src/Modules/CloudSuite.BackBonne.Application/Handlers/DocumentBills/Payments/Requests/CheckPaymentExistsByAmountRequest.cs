using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests
{
    public class CheckPaymentExistsByAmountRequest : IRequest<CheckPaymentExistsByAmountResponse>
    {
        public Guid Id { get; private set; }

        public decimal Amount { get; set; }

        public CheckPaymentExistsByAmountRequest(decimal amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
        }
    }
}
