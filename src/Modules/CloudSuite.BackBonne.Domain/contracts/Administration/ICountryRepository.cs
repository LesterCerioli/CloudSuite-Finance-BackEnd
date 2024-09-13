using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface ICountryRepository
    {
         Task<Country> GetByCountryName(string? countryName);

         Task<IEnumerable<Country>> GetList();

         Task Add(Country country);

         void Update(Country country);

         void Remove(Country country);
    }
}