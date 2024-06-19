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
        public ExchangeRate(string? currency, decimal? valueInBRL, decimal? valueInUS, decimal? valueInEuro, DateTime? lastUpdated, decimal? dollarReference, decimal? euroRefference)
        {
            Currency = currency;
            ValueInBRL = valueInBRL;
            ValueInUS = valueInUS;
            ValueInEuro = valueInEuro;
            LastUpdated = lastUpdated;
            DollarReference = dollarReference;
            EuroRefference = euroRefference;
        }

        public string? Currency { get; private set; } // Ex: BRL, USD, EUR

        public decimal? ValueInBRL { get; private set; } // Valor de 1 unidade da moeda em BRL

        public decimal? ValueInUS { get; private set; } // Valor de 1 unidade da moeda em Dolar

        public decimal? ValueInEuro { get; private set; } // Valor de 1 unidade da moeda em Euro

        public DateTime? LastUpdated { get; private set; }

        //Valor de referência do Dólar em Reais
        public decimal? DollarReference { get; private set; }

        //Valor de refrência do Euro em dólares
        public decimal? EuroRefference { get; private set; }
    }
}
