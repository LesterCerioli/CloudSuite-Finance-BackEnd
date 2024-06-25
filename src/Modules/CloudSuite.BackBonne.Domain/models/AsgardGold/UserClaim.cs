using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AsgardGold
{
    public class UserClaim : Entity, IAggregateRoot
    {
        public UserClaim(string type, string value)
        {
            Type = type;
            Value = value;
        }

        public string? Type { get; private set; }

        public string? Value { get; private set; }
    }
}
