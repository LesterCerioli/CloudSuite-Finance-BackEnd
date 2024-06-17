using System.Collections.Generic;
using System.Threading.Tasks;
using AdmissionalRegisterService.Model;
using CloudSuite.Domain.Models;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IDependentRepository
    {
        Task<Dependent> GetById(int dependentId);

        Task<IEnumerable<Dependent>> GetAll();

        Task Add(Dependent dependent);

        void Update(Dependent dependent);

        void Remove(Dependent dependent);
    }
}