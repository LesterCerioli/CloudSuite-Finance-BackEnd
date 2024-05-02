using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class CostCenter : Entity, IAggregateRoot
    {
        public string? COD_CENTRO_CUSTO { get; private set; }

        public string? Description { get; private set; }

        public int? ID_CENTRO_CUSTO_PAI { get; private set; }

        public string? Cod_Desc { get; private set; }
    }
}
