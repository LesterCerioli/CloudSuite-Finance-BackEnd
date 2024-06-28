using CloudSuite.BackBonne.Domain.models.Accounts_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts
{
    public interface IBankRepository
    {
        Task<Bank> GetByCodeBank(string bankCode);

        Task<Bank> GetByBankName(string bankName); 

        Task<Bank> GetByBankId (string bankId);

        Task<IEnumerable<Bank>> GetBankList();

        Task Add(Bank bank);

        void Update(Bank bank);

        void Remove(Bank bank);
    }
} 
