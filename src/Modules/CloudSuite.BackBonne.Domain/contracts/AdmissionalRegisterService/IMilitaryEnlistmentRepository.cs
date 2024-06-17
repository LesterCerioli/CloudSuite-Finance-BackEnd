using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IMilitaryEnlistmentRepository
    {
        Task<MilitaryEnlistment> GetById(int militaryEnlistmentId);

        Task<IEnumerable<MilitaryEnlistment>> GetAll();

        Task Add(MilitaryEnlistment militaryEnlistment);

        void Update(MilitaryEnlistment militaryEnlistment);

        void Remove(MilitaryEnlistment militaryEnlistment);
    }
}