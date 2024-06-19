using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.EmployeesPayments
{
    public class TimeRegister : Entity, IAggregateRoot
    {
        public DateTime? Date { get; private set; }

        public int? WorkTimes { get; private set; }

        public Employee Employee { get; private set; }
    }
}
