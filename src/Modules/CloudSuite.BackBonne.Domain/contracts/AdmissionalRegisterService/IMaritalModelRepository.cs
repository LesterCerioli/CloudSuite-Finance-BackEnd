using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IMaritalModelRepository
    {
        Task<MaritalModel> GetById(int maritalStatusId);

        Task<IEnumerable<MaritalModel>> GetAll();

        Task Add(MaritalModel maritalModel);

        void Update(MaritalModel maritalModel);

        void Remove(MaritalModel maritalModel);
    }
}
