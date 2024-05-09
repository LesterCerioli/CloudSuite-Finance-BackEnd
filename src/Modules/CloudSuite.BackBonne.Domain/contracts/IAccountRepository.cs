using CloudSuite.BackBonne.Domain.models.Accounts_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.contracts
{
    public interface IAccountRepository
    {
        Task<Account> GetByAccountNumber(string accountNumber, string accountDigit);

        Task<IEnumerable<Account>> GetAccountsList();

        Task Add(Account account);

        void Update(Account account);

        void Remove(Account account);
    }
}
