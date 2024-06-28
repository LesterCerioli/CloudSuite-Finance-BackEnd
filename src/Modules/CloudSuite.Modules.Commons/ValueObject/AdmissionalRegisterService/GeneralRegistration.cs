using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class GeneralRegistration
    {
        public int GeneralRegistrationId { get; set; }
        public string Number { get; set; }
        public string EmissionInssuer { get; set; }
        public DateTime? dtExpedition { get; set; }
    }
}