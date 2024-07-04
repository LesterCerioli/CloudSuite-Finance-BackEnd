using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface ICountryRepository
    {
        Task<Country> GetByName(string name);

        Task<Country> GetByState(State state);
        Task<IEnumerable<Country>> GetList();

        Task Add(Country country);

        void Update(Country country);

        void Remove(Country country);
    }
}       