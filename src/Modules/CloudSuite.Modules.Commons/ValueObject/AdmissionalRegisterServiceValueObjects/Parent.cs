using CloudSuite.Modules.Commons.Enumerators.AdminssionalRegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class Parent : NetDevPack.Domain.ValueObject
    {
        public string Name { get; set; }
        public int NationalId { get; set; }
        public ParentType Type { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }

    
} 
   