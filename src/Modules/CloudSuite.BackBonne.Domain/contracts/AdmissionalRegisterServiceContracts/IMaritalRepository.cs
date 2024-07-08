using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IMaritalRepository 

    { 
        Task<Marital> GetMaritalByName(string name);

        Task<Marital> GetMaritalByMaritalStatus(int maritalStatus);

        Task<Marital> GetByDescriptionCommons(DescriptionCommons descriptionCommons);
        Task<IEnumerable<Marital>> GetList();

        Task Add(Marital maritalModel);

        void Update(Marital maritalModel);

        void Remove(Marital maritalModel);
    }
}  
    