using NetDevPack.Domain;

namespace CloudSuite.BackBonne.Domain.models.BankIntegrationService.DICT
{
    public class AddressingKeyAccountHolder : Entity, IAggregateRoot
    {
        public AddressingKeyAccountHolder(string? taxId, string? taxIdMask, string? name, string? tradeName, string? ownerType)
        {
            TaxId = taxId;
            TaxIdMask = taxIdMask;
            Name = name;
            TradeName = tradeName;
            OwnerType = ownerType;
        }

        public string? TaxId { get; private set; }

        public string? TaxIdMask { get; private set; }

        public string? Name { get; private set; }

        public string? TradeName { get; private set; }

        public string? OwnerType { get; private set; }


        
    }
}