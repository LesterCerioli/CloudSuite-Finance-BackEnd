using CloudSuite.BackBonne.Domain.models.DownloadBills;
using CloudSuite.Modules.Commons.ValueObjects;

namespace CloudSuite.BackBonne.Domain.contracts.DownloadBills
{
    public interface ISupplierRepository
    {
        Task<Supplier> GetByCnpj(CNPJ Cnpj);

        Task<Supplier> GetBySupplierName(string supplierName);

        Task<IEnumerable<Supplier>> GetList();

        Task Add(Supplier supplier);

        void Update(Supplier supplier); 

        void Remove(Supplier supplier);
    }
}
