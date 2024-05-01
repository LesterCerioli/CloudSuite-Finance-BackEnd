using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class Country : Entity, IAggregateRoot
    {
        public string? CountryName { get; private set; }
    }
}
