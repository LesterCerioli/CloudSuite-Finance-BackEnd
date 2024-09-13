using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface IAddressRepository
    {
         Task<Address> GetByAddressLine(string addressLine);

         Task<IEnumerable<Address>> GetList();

         Task Add(Address address);

         void Update(Address address);

         void Remove(Address address);
    }
}