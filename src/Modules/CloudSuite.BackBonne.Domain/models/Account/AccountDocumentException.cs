using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AccountDocumentException : Entity, IAggregateRoot
    {
        public long? AccountNumber { get; private set; }

        public long? AccountAgency { get; private set; }

        public int? SStatus { get; private set; }
    }
}
