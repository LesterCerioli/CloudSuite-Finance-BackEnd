using CloudSuite.BackBonne.Domain.models.Administration;

namespace CloudSuite.BackBonne.Domain.contracts.Administration
{
    public interface IStateRepository
    {
         Task<State> GetByStateName(string? stateName);

         Task<IEnumerable<State>> GetList();

         Task Add(State state);

         void Update(State state);

         void Remove(State state);
    }
}