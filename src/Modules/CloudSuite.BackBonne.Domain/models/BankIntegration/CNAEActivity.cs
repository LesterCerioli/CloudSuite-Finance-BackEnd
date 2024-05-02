using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class CNAEActivity : Entity, IAggregateRoot
    {
        public string? Description { get; private set; }
    }
}
