using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class AssociationType : Entity, IAggregateRoot
    {
        //public char ID_TIPO_ASSOCIACAO { get; set; }

        public string? Description { get; private set; }
    }
}
