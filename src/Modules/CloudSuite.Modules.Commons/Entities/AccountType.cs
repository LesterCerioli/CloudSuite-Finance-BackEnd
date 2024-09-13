using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloudSuite.Modules.Commons.Entities
{
    [DataContract]
    public class AccountType
    {
        /// <summary>
        /// Returns a string representation of the AccountType object.
        /// </summary>
        /// <returns>String representation of the object</returns>
        public override string ToString()
        {
            return nameof(AccountType); // Simplified, avoids unnecessary StringBuilder usage
        }

        /// <summary>
        /// Returns the JSON string representation of the AccountType object.
        /// </summary>
        /// <returns>JSON string representation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}