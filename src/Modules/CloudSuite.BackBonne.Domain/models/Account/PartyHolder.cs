using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class PartyHolder : Entity, IAggregateRoot
    {
        public string? ModuleName { get; private set; }

        public string? EntityType { get; private set; }

        public string? PartyCgeName { get; private set; }

        public string? PartyName { get; private set; }

        public string? TaxIdentificationOn { get; private set; }
    }
}
