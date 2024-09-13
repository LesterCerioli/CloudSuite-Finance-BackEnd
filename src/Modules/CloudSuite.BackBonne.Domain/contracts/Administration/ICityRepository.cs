using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface ICityRepository
    {
         Task<City> GetByCityName(string cityName);

         Task<IEnumerable<City>> GetList();

         Task Add(City city);

         void Update(City city);

         void Remove(City city);
    }
}