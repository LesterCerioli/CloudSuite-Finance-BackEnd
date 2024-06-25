using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Domain;


namespace CloudSuite.Modules.Commons.ValueObject
{
    public class CEP : NetDevPack.Domain.ValueObject
    {
        public string Cep { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public string Service { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}