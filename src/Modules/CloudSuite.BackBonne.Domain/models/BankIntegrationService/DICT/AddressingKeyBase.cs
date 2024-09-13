using System.Text.Json;
using NetDevPack.Domain;

namespace CloudSuite.BackBonne.Domain.models.BankIntegrationService.DICT
{
    public class AddressingKeyBase : Entity, IAggregateRoot
    {
        public string? Key { get; private set; }

        public string? KeyType { get; private set; }

        public override string ToString()
        {
            return $"AddressingKeyBase {{ Key = {Key}, KeyType = {KeyType} }}";
        }


        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
        
    }
}