using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class SystemAccount : Entity, IAggregateRoot
    {
        public string? Name { get; private set; }

        public bool? IsProper { get; private set; }
    }
}
