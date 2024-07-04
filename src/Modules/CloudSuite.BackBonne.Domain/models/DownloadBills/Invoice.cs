using CloudSuite.Modules.Commons.Enumerators;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.DownloadBills
{
    public class Invoice : Entity, IAggregateRoot
    {
        public Invoice(decimal? amount, DateTime? dueDate, DateTimeOffset? paymentDate, InvoiceStatus status)
        {
            Amount = amount;
            DueDate = dueDate;
            PaymentDate = paymentDate;
            Status = status;
        }

        public decimal? Amount { get; private set; }

        public DateTime? DueDate { get; private set; }

        public DateTimeOffset? PaymentDate { get; private set; }

        public InvoiceStatus Status { get; private set; }

        // Relacionamento
        public Supplier Supplier { get; private set; }
    }
}
