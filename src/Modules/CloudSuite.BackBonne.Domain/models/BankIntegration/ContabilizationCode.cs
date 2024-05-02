using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class ContabilizationCode : Entity, IAggregateRoot
    {
        public long? COD_CONTA_CONTABIL { get; private set; }

        public long? COD_CONTA_PAI { get; private set; }

        public string? Name { get; private set; }

        public long? COD_CONTA_REDUZIDA { get; private set; }
    }
}
