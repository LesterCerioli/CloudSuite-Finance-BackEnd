using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class ParameterDescription : Entity, IAggregateRoot
    {
        public ParameterDescription(string? name, string? type, bool? required)
        {
            Name = name;
            Type = type;
            Required = required;
        }

        public string? Name { get; private set; }

        public string? Type { get; private set; }

        public bool? Required { get; private set; }
    }
}
