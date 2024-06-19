using CloudSuite.BackBonne.Domain.models.DownloadBills;
using CloudSuite.Modules.Commons.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.DownloadBills
{
    public interface ISupplierRepository
    {
        Task<Supplier> GetByCnpj(CNPJ cNPJ);

        Task<Supplier> GetBySupplierName(string supplierName);

        Task<IEnumerable<Supplier>> GetList();

        Task Add(Supplier supplier);

        void Update(Supplier supplier); 

        void Remove(Supplier supplier);
    }
}
