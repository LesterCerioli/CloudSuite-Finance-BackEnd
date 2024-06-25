using CloudSuite.Modules.Commons.ValueObject;
using CloudSuite.Modules.Commons.ValueObjects;
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
        public Supplier(string? supplierName, Cnpj? cNPJ)
        {
            SupplierName = supplierName;
            CNPJ = cNPJ;
            Invoices = new List<Invoice>();
        }

        public string? SupplierName { get; private set; }
        
        public Cnpj? CNPJ { get; private set; }

        // Relacionamento
        public ICollection<Invoice> Invoices { get; private set; }

    }
}
