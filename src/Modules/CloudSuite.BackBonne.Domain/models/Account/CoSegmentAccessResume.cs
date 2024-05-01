using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class CoSegmentAccessResume : Entity, IAggregateRoot
    {
        public string? Description { get; private set; }

        public bool? Enabled { get; private set; }

        public bool? Digital { get; private set; }

        public string? Code { get; private set; }
    }
}
