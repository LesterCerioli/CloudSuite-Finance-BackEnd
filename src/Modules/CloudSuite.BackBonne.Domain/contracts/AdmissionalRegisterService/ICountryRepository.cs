using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface ICountryRepository
    {
        Task<Country> GetById(int countryId);

        Task<IEnumerable<Country>> GetAll();

        Task Add(Country country);

        void Update(Country country);

        void Remove(Country country);
    }
}    