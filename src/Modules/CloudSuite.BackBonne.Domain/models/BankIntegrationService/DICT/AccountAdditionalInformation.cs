using System.Runtime.Serialization;
using CloudSuite.BackBonne.Domain.models.BankIntegration;
using NetDevPack.Domain;
using Newtonsoft.Json;

namespace CloudSuite.BackBonne.Domain.models.BankIntegrationService.DICT
{
    public class AccountAdditionalInformation : Entity, IAggregateRoot
    {
        public int? Branch { get; private set; }

        public long? AccountNumber { get; private set; }

        
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Gets or Sets OpeningDate
        /// </summary>
        [DataMember(Name = "openingDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingDate")]
        public string? OpeningDate { get; private set; }

               

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        
    }
}