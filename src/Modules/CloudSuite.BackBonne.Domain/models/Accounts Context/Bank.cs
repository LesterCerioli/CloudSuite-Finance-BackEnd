using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Accounts_Context
{
    public class Bank : Entity, IAggregateRoot
    {
        public Bank(int? codebank, string? bankName)
        {
            Codebank = codebank;
            BankName = bankName;
        }

        public int? Codebank { get; private set; }

        public string? BankName { get; private set; }
    }
}
