using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.EmployeesPayments
{
    public class ExchangeRate : Entity, IAggregateRoot
    {
        public string? Currency { get; private set; } // Ex: BRL, USD, EUR

        public decimal? ValueInBRL { get; private set; } // Valor de 1 unidade da moeda em BRL

        public decimal? ValueInUS { get; private set; } // Valor de 1 unidade da moeda em Dolar

        public decimal? ValueInEuro { get; private set; } // Valor de 1 unidade da moeda em Euro

        public DateTime? LastUpdated { get; private set; }
    }
}
