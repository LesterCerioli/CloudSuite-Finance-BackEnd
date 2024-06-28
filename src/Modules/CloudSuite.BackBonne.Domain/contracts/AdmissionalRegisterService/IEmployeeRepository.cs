using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int employeeId);
        Task<IEnumerable<Employee>> GetAll();
        Task<IEnumerable<Employee>> GetByName(string name);
        Task<Employee> GetByTaxPayer(string taxPayer);

        Task Add(Employee employee);

        void Update(Employee employee);

        void Remove(Employee employee);
    }
}
 