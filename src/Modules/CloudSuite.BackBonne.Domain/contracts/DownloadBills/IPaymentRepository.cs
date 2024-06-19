using CloudSuite.BackBonne.Domain.models.DownloadBills;
using CloudSuite.Modules.Commons.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.DownloadBills
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByAmount(decimal amount);

        Task<Payment> GetByPaymentDate(DateTime paymentDate);

        Task<Payment> GetByPaymentMethod(PaymentMethod paymentMethod);

        Task<IEnumerable<Payment>> GetList();

        Task Add(Payment supplier);

        void Update(Payment supplier);

        void Remove(Payment supplier);
    }
}
