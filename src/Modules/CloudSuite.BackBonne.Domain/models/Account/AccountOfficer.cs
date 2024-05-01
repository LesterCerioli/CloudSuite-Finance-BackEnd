using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AccountOfficer : Entity, IAggregateRoot
    {

        public long? Cge { get; private set; }

        public string? PartyName { get; private set; }

        public bool? IsMain { get; private set; }
    }
}
