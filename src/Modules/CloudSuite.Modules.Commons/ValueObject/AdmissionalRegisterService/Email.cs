using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Email: NetDevPack.Domain.ValueObject
    {
        public string MailName { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}   