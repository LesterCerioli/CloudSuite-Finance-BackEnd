using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface IDependentRepository
    {
        Task<Dependent> GetbyName(string? name);

        Task<IEnumerable<Dependent>> GetList();

        Task Add(Dependent dependent);

        void Update(Dependent dependent);

        void Remove(Dependent dependent);
         
    }
}