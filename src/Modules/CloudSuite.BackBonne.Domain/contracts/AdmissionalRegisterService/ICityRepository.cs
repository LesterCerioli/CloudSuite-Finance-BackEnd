using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface ICityRepository
    {
        Task<City> GetById(int cityId);

        Task<IEnumerable<City>> GetAll(); 

        Task Add(City city);

        void Update(City city);

        void Remove(City city);
    } 
}  