using CloudSuite.Modules.Commons.ValueObject;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.DownloadBills
{
    public class Supplier : Entity, IAggregateRoot
    {
        public string? SupplierName { get; private set; }
        
        public CNPJ CNPJ { get; private set; }

        // Relacionamento
        public ICollection<Invoice> Invoices { get; private set; }

    }
}
