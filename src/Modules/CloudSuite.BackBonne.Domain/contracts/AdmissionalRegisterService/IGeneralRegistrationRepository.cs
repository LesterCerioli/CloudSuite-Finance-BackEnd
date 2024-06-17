using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IGeneralRegistrationRepository
    {
        Task<GeneralRegistration> GetById(int generalRegistrationId);

        Task<IEnumerable<GeneralRegistration>> GetAll();

        Task Add(GeneralRegistration generalRegistration);

        void Update(GeneralRegistration generalRegistration);

        void Remove(GeneralRegistration generalRegistration);
    }
}