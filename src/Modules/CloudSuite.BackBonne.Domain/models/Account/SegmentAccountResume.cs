using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class SegmentAccountResume : Entity, IAggregateRoot
    {
        public string? Description { get; private set; }

        public bool? Enabled { get; private set; }
    }
}
