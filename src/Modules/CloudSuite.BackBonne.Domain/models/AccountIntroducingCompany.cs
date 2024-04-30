using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models
{
    public class AccountIntroducingCompany : Entity, IAggregateRoot
    {
        public long? Cge { get; private set; }

        public long? PartyName { get; private set; }

        public bool? IsSpecialLooker { get; private set; }

        public string? Username { get; private set; }
    }
}
