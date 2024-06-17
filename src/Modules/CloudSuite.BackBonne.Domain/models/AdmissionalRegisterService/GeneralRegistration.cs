using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class GeneralRegistration : Entity, IAggregateRoot
    {
        public int GeneralRegistrationId { get; private set; }
        public string Number { get; private set; }
        public string EmissionInssuer { get; private set; }
        public DateTime? DtExpedition { get; private set; }

        // Construtor padrão sem parâmetros
        protected GeneralRegistration() { }

        public GeneralRegistration(int generalRegistrationId, string number, string emissionInssuer, DateTime? dtExpedition)
        {
            GeneralRegistrationId = generalRegistrationId;
            Number = number;
            EmissionInssuer = emissionInssuer;
            DtExpedition = dtExpedition;
        }

        // Aqui poderiam ser adicionados métodos específicos de negócio relacionados ao registro geral, se necessário
    }
}