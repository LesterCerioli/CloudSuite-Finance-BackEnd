using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AgencyAccountResume
    {
        public string? Code { get; private set; }

        public char Digit { get; private set; }

        public string? Description { get; private set; }

        public bool? Enabled { get; private set; }

        public BankAccountResume Bank { get; private set; }
    }
}
