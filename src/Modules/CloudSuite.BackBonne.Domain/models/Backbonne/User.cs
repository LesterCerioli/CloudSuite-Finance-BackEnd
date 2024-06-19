using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    internal class User : Entity, IAggregateRoot
    {
        public string? Name { get; private set; }

        public int? CompanyId { get; private set; }

        public string? Token { get; private set; }

        public string? PhotoURI { get; private set; }
    }
}
