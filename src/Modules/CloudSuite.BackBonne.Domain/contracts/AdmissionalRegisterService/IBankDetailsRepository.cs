using AdmissionalRegisterService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts.AdmissionalRegisterService
{
    public interface IBankDetailsRepository
    {
        Task<BankDetails> GetById(int bankId);
        Task<IEnumerable<BankDetails>> GetAll();

        Task Add(BankDetails bankDetails);

        void Update(BankDetails bankDetails);

        void Remove(BankDetails bankDetails);
    }
} 