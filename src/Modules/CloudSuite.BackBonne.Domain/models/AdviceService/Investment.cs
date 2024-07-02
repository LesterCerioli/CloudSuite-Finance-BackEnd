using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace CloudSuite.BackBonne.Domain.models.AdviceService
{
    public class Investment : Entity, IAggregateRoot
    {
        public Investment(string taxPayerRegistry, string name, string investmentProfile)
        {
            TaxPayerRegistry = taxPayerRegistry;
            Name = name;
            InvestmentProfile = investmentProfile;
        }
        public Investment() { }

        public string? TaxPayerRegistry { get; private set; }

        public string? Name { get; private set; }

        public string? InvestmentProfile { get; private set; }
    }
}