using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Modules.Common.ValueObjects;


namespace CloudSuite.BackBonne.Domain.models.BPC
{
    public class PosicaoRV : Entity, IAggregateRoot
    {
        public string? NomeFundo { get; private set; }

        public Cnpj Cnpj { get; private set; }

        public string? CodCarteira { get; private set; }

        public string? NomeCarteira { get; private set; }

        public string? CodPapel { get; private set; }

        public string? Corretora { get; private set; }

        public decimal? QtdSaldo { get; private set; }

        public decimal? QtdBloq { get; private set; }

        public decimal? QtdD1 { get; private set; }

        public decimal? QtdD2 { get; private set; }

        public decimal? QtdD3 { get; private set; }

        public decimal? QtdPendencia { get; private set; }

        public DateTime? DateCarteira { get; private set; }

        public decimal? QtdTotalSaldo { get; private set; }
        
    }
}