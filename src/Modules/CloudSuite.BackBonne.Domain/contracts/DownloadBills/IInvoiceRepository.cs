using CloudSuite.BackBonne.Domain.models.DownloadBills;
using CloudSuite.Modules.Commons.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.DownloadBills
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetByAmount(decimal? amount);

        Task<Invoice> GetByDueDate(DateTime? dueDate);

        Task<Invoice> GetByPaymentDate(DateTimeOffset? paymentDate);

        Task<Invoice> GetByInvoiceStatus(int? status);

        Task<IEnumerable<Invoice>> GetList();

        Task Add(Invoice supplier);

        void Update(Invoice supplier);

        void Remove(Invoice supplier);
    }
}
