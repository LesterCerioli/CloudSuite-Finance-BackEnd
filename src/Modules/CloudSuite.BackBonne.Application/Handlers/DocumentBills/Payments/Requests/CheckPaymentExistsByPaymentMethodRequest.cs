using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.Modules.Commons.Enumerators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests
{
    public class CheckPaymentExistsByPaymentMethodRequest : IRequest<CheckPaymentExistsByPaymentMethodResponse>
    {
        public Guid Id { get; private set; }

        public PaymentMethod PaymentMethod { get; set; }

        public CheckPaymentExistsByPaymentMethodRequest(PaymentMethod paymentMethod)
        {
            Id = Guid.NewGuid();
            PaymentMethod = paymentMethod;
        }
    }
}
