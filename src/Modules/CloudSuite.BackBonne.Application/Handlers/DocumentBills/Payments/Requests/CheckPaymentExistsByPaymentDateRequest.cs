using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
