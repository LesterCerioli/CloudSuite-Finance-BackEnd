using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BPC
{
    public class RVPosition : Entity, IAggregateRoot
    {
        public string? CodCarteira { get; private set; }

        public string? NomCarteira { get; private set; }

        public string? CodBovespa { get; private set; }

        public string? ApelidoCorretora { get; private set; }

        public decimal? QtdSaldo { get; private set; }

        public decimal? QBloqSdo { get; private set; }

        public decimal? QTotD1 { get; private set; }

        public decimal? QTotD2 { get; private set; }

        public decimal? QTotD3 { get; private set; }

        public decimal? QTotPend { get; private set; }

        public DateTime? DtaSaldo { get; private set; }

        public string? NomCliente { get; private set; }

        public string? NumCGC { get; private set; }

        public decimal? Saldo { get; private set; }
        
    }
}