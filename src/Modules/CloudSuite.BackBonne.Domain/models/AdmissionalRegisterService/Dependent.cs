using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Dependent : Entity, IAggregateRoot
    {
        public int DependentId { get; private set; }
        public string Name { get; private set; }
        public int Kinship { get; private set; }
        public bool IsDependentIRRF { get; private set; }
        public DateTime DtBirth { get; private set; }
        public string TaxPayerRegistry { get; private set; }

        public Dependent(int dependentId, string name, int kinship, bool isDependentIRRF, DateTime dtBirth, string taxPayerRegistry)
        {
            DependentId = dependentId;
            Name = name;
            Kinship = kinship;
            IsDependentIRRF = isDependentIRRF;
            DtBirth = dtBirth;
            TaxPayerRegistry = taxPayerRegistry;
        }

        // Aqui poderiam ser adicionados métodos específicos de negócio relacionados aos dependentes, se necessário
    }
}