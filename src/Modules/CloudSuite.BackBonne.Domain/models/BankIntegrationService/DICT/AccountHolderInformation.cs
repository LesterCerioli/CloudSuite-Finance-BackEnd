using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloudSuite.BackBonne.Domain.models.BankIntegrationService.DICT
{
    public class AccountHolderInformation
    {
        public AccountHolderInformation(string? taxId, string? tradeName, string? name)
        {
            TaxId = taxId;
            TradeName = tradeName;
            Name = name;
        }

        [DataMember(Name="taxId", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "taxId")]
        public string? TaxId { get; private set; }

        /// <summary>
        /// Information about the tradename holder user, if associate is legal person.
        /// </summary>
        /// <value>Information about the tradename holder user, if associate is legal person.</value>
        [DataMember(Name="tradeName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "tradeName")]
        public string? TradeName { get; private set; }

        /// <summary>
        /// Information about the name holder user.
        /// </summary>
        /// <value>Information about the name holder user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; private set; }
        
    }
}