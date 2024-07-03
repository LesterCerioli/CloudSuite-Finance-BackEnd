using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IRelativeDegreeRepository 
    {
       Task<RelativeDegree> GetByDescriptionCommons(DescriptionCommons descriptionCommons);
        Task<IEnumerable<RelativeDegree>> GetList();

       Task Add(RelativeDegree relativeDegree);

        void Update(RelativeDegree relativeDegree); 

        void Remove(RelativeDegree relativeDegree);
  
    }
}    
       