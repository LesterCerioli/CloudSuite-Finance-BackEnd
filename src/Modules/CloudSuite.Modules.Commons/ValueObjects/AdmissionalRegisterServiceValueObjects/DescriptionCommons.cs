using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class DescriptionCommons: NetDevPack.Domain.ValueObject
    {
        public string Description { get; set; }

        public static implicit operator string(DescriptionCommons v)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
 