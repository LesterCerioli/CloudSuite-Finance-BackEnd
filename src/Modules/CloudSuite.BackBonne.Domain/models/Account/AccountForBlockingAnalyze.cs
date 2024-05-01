using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AccountForBlockingAnalyze : Entity, IAggregateRoot
    {
        public long? IdAccount { get; private set; }

        public long? IdAccountRelationshipEntity { get; set; }

        public long IdAccountType { get; private set; }

        public long? IdAccountClientType { get; private set; }

        public long? IdCurrentStatus { get; private set; }


        public long? IdPartyHolerMyProperty { get; private set; }

        public long? IdRelationshipRole { get; private set; }
        public bool? TransferedAccount { get; private set; }

        public DateTime? OperatingDate { get; private set; }

        public string? CgeMainOfficer { get; private set; }

        public string? ContacCodeGeneralOfficer { get; private set; }

        public DateTime? EndRelationshipDate { get; private set; }

        public long? CgeFundAdministrator { get; set; }

        public long? CgeFoundManager { get; private set; }

        public bool? HasReturn { get; private set; }
    }
}
