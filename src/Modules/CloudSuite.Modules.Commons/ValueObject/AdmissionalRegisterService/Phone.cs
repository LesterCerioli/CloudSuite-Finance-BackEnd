using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public int StateCode { get; set; }
        public string Number { get; set; }
        public PhoneType Type { get; set; }
        public string ContactName { get; set; }
    }

    public enum PhoneType
    {
        Residencial = 1,
        Mobile = 2,
        Emergency = 3
    }
}    