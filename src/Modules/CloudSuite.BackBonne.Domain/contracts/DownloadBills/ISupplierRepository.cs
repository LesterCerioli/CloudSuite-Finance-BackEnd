using CloudSuite.BackBonne.Domain.models.DownloadBills;
using CloudSuite.Modules.Common.Valueobjects;

namespace CloudSuite.BackBonne.Domain.contracts.DownloadBills
{
    public interface ISupplierRepository
    {
        Task<Supplier> GetByCnpj(Cnpj Cnpj);

        Task<Supplier> GetBySupplierName(string supplierName);

        Task<IEnumerable<Supplier>> GetList();

        Task Add(Supplier supplier);

        void Update(Supplier supplier); 

        void Remove(Supplier supplier);
    }
}
