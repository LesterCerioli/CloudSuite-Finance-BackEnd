using AdmissionalRegisterService.Model;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface IAddressRepository
    {
        Task<Address> GetById(int id);

        Task<IEnumerable<Address>> GetAll();

        Task Add(Address address);

        void Update(Address address);

        void Remove(Address address);
    }
}