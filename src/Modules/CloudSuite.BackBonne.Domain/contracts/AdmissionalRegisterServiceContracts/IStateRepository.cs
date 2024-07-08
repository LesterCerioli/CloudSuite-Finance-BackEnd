using AdmissionalRegisterService.Model;
using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService.CloudSuite.BackBonne.Domain.models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface  IStateRepository
    {  
        Task<State> GetByName(string name); 

        Task<State> GetByCountry( Country country);
        Task<IEnumerable<State>> GetList(); 

        Task Add(State state); 

        void Update(State state); 
          
        void Remove (State state);
    }
}
         