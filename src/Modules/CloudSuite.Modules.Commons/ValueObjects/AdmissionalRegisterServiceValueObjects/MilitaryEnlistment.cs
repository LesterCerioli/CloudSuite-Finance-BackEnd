using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class MilitaryEnlistment: NetDevPack.Domain.ValueObject
    {
        public string Number { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}    