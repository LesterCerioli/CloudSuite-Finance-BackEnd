using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Accounts_Context
{
    public class Account : Entity, IAggregateRoot
    {
        public Account(string? accountNumber, int accountDigit)
        {
            AccountNumber = accountNumber;
            AccountDigit = accountDigit;
        }

        public string? AccountNumber { get; private set; }

        public int AccountDigit { get; private set; }
    }
}
