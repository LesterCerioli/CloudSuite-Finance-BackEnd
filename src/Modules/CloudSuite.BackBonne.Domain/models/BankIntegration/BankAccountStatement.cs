using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class BankAccountStatement : Entity, IAggregateRoot
    {
        /// <summary>
        /// Nome no Matera: data_lancamento
        /// </summary>
        public DateTime? EntryDate { get; private set; }

        /// <summary>
        /// Nome no Matera: desc_historico
        /// </summary>
        public string? Description { get; private set; }

        /// <summary>
        /// Nome no Matera: tipo_lancamento
        /// </summary>
        public string? EntryType { get; private set; }

        /// <summary>
        /// Nome no Matera: valor
        /// </summary>
        public decimal? Value { get; private set; }
    }
}
