using CloudSuite.BackBonne.Domain.models.Administration;
using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Address = CloudSuite.BackBonne.Domain.models.Administration.Address;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IEmployeeRepository
    { 
        Task<Employee> GetByName(string name);

        Task<Employee> GetByDeficient(int deficient);

        Task<Employee> GetByMaritalStatus(int maritalStatus); 

        Task<Employee> GetByCountryBirth(int countryBirth);

        Task<Employee> GetByUfBirth(int ufBirth);

        Task<Employee> GetByCityBirth(int cityBirth); 

        Task<Employee> GetByEducationLevel(int educationLevel); 

        Task<Employee> GetByInstitutionEducational(int institutionEducational); 

        Task<Employee> GetByCourse(int course ); 

        Task<Employee> GetByNationalRegistry(string nationalRegistry);

        Task<Employee> GetByAddress(Address address); 

        Task<Employee> GetByGeneralRegistration(GeneralRegistration generalRegistration); 

        Task<Employee> GetByPIS(PIS pIS); 

        Task<Employee> GetByWorkPermit(WorkPermit workPermit); 

        Task<Employee> GetByVotersTitle(VotersTitle votersTitle);

        Task<Employee> GetByTaxPayer(string taxPayer);


        Task<IEnumerable<Employee>> GetList();

        

        Task Add(Employee employee);

        void Update(Employee employee);

        void Remove(Employee employee);
    }
} 
  