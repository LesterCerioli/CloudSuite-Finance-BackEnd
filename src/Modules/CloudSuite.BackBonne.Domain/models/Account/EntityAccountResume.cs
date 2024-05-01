using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class EntityAccountResume : Entity, IAggregateRoot
    {
        public long? Cge { get; private set; }


    }
}
