using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{

        public class VotersTitle : NetDevPack.Domain.ValueObject 
        {
            public string? Number { get; set; }

            public string? Zone { get; set; }

            public string? Section { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
    }
  