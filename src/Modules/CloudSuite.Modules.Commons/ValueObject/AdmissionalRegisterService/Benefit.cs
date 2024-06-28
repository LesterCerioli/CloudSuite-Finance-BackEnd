using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class Benefit
    {
        public int BenefitId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
   