using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class Dependent : Entity, IAggregateRoot
    {
        public Dependent(string? name, int? kinship, bool? isDependentIRRF, DateTime? dtBirth, string? taxPayerRegistry)
        {
            Name = name;
            Kinship = kinship;
            IsDependentIRRF = isDependentIRRF;
            DtBirth = dtBirth;
            TaxPayerRegistry = taxPayerRegistry;
        }

        public string? Name { get; private set; }

        public int? Kinship { get; private set; }

        public bool? IsDependentIRRF { get; private set; }

        public DateTime? DtBirth { get; private set; }

        public string? TaxPayerRegistry { get; private set; }
    }
}
