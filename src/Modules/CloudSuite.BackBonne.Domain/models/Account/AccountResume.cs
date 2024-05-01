using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Account
{
    public class AccountResume : Entity, IAggregateRoot
    {
        public string? Number { get; private set; }

        public AgencyAccountResume Bank { get; private set; }

        public AgencyAccountResume MAgency { get; private set; }


    }
}
