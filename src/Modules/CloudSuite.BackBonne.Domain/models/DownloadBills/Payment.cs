using CloudSuite.Modules.Commons.Enumerators;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.DownloadBills
{
    public class Payment : Entity, IAggregateRoot
    {
        public Payment(decimal? amount, DateTime? paymentDate, PaymentMethod? paymentMethod)
        {
            Amount = amount;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
        }

        public decimal? Amount { get; private set; }

        public DateTime? PaymentDate { get; private set; }

        public PaymentMethod? PaymentMethod { get; private set; }

        // Relacionamento
        public Invoice Invoice { get; private set; }
    }
}
