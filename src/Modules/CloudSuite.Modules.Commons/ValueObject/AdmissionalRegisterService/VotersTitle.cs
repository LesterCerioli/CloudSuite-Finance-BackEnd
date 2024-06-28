using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    namespace AdmissionalRegisterService.Model
    {
        public class VotersTitle
        {
            public int VotersTitleId { get; set; }
            public string Number { get; set; }
            public string Zone { get; set; }
            public string Section { get; set; }
        }
    }
}