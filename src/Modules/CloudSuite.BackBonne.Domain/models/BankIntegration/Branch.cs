using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class Branch : Entity, IAggregateRoot
    {
        public string? Name { get; private set; }

        public string? CompanyName { get; private set; }
        
        public Company Company { get; private set; }
        
        public string? CNPJ { get; set; }
        
        public string COD_UF { get; set; }
    }
}
