using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class Address : Entity, IAggregateRoot
    {
        public State State { get; private set; }

        public City City { get; private set; }

        public string? Neighborhood { get; private set; }
        public string? ZipCode { get; private set; }
    }
}
