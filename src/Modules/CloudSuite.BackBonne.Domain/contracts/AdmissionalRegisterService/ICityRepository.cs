using AdmissionalRegisterService.Model;
using DocumentFormat.OpenXml.Bibliography;

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