using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models
{
    public class DataBank : Entity, IAggregateRoot
    {
        public string? BankCode { get; private set; }

        public string? BranchNumber { get; private set; }

        public string? BranchName { get; private set; }

        public char DigitBranch { get; private set; }

        public string? AccountNumber { get; private set; }

        public char AccouyntNumberDigit { get; private set; }
    }
}
