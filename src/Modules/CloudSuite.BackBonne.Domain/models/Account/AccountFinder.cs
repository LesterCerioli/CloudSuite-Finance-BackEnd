using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AccountFinder : Entity, IAggregateRoot
    {
        public long? FinderCge { get; private set; }

        public string? FinderName { get; private set; }
    }
}
