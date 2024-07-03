using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalEegisterService
{
    public interface ICityRepository
    {
        Task<City> GetByName(string name); 

        Task<City> GetByState(State state); 

        Task<IEnumerable<City>> GetList(); 

        Task Add(City city);

        void Update(City city);

        void Remove(City city);
    } 
}    