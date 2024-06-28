using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IRelativeDegreeRepository 
    {
        Task<RelativeDegree> GetById(int relativeDeegreeId);

        Task<IEnumerable<RelativeDegree>> GetAlll();

       Task Add(RelativeDegree relativeDegree);

        void Update(RelativeDegree relativeDegree); 

        void Remove(RelativeDegree relativeDegree);
  
    }
}   
      