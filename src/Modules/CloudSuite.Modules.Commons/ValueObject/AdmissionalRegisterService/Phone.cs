using CloudSuite.Modules.Commons.Enumerators.AdminssionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class Phone : NetDevPack.Domain.ValueObject
    {
        public int StateCode { get; set; }
        public string Number { get; set; }
        public PhoneType Type { get; set; }
        public string ContactName { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }

    
}    