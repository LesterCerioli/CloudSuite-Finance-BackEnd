using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class ModelDescription : Entity, IAggregateRoot
    {
        public ModelDescription(string? name)
        {
            Name = name;
        }

        public string? Name { get; private set; }
    }
}
