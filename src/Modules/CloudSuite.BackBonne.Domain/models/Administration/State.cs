using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class State : Entity, IAggregateRoot
    {
        public string? StateName { get; private set; }

        public string? UF { get; private set; }
    }
}
