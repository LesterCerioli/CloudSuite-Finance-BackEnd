using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.EmployeesPayments
{
    public class Employee : Entity, IAggregateRoot
    {
        public string? Cpf { get; private set; }

        public string? Fullname { get; private set; }
    }
}
