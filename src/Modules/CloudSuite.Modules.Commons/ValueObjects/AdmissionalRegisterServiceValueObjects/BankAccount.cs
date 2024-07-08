using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class BankAccount : NetDevPack.Domain.ValueObject
    {
        public int? BankId { get; set; }
        public string? Branch { get; set; }
        public string? BranchDigit { get; set; }
        public string? Account { get; set; }
        public string? AccountDigit { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}                         