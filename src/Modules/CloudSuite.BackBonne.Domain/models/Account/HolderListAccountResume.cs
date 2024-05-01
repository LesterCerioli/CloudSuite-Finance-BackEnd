using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class HolderListAccountResume : Entity, IAggregateRoot
    {
        public EntityAccountResume Main { get; private set; }

        public List<EntityAccountResume> CoHoldersList { get; private set; }
    }
}
