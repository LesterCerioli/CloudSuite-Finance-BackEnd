using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IMaritalRepository
    {
        Task<Marital> GetById(int maritalStatusId);

        Task<IEnumerable<Marital>> GetAll();

        Task Add(Marital maritalModel);

        void Update(Marital maritalModel);

        void Remove(Marital maritalModel);
    }
}
  