using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class BankAccountResume : Entity, IAggregateRoot
    {
        public string? Code { get; private set; }

        public string? Description { get; private set; }

        public long? AccountRelatedEntityId { get; private set; }
    }
}
