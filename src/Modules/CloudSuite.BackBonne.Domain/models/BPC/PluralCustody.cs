using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.Modules.Commons.ValueObject;


namespace CloudSuite.BackBonne.Domain.models.BPC
{
    public class PluralCustody : Entity, IAggregateRoot
    {
        [Required]
        [StringLength(14)]
        public Cnpj Cnpj { get; private set; }

        [Required]
        public DateTime? Data { get; private set; }

        [Required]
        [StringLength(50)]
        public string? SiglaSistema { get; private set; }

        [Required]
        [StringLength(50)]
        public string? CodIDInstituicao { get; private set; }

        public int? CodIntegracao { get; private set; }

        [Required]
        [StringLength(50)]
        public string? CodIDCliente { get; private set; }

        public DateTime? DtaLiquidacao { get; private set; }

        public int? TpoOperacao { get; private set; }

        public decimal? ValBoleta { get; private set; }

        public decimal? TxaBoleta { get; private set; }

        public int? TpoTaxaOper { get; privaete set; }

        public int? PzoBoletaDU { get; private set; }

        public int? SeqClearing { get; private set; }

        public DateTime DtaVolta { get; set; }

        [StringLength(50)]
        public string CodIDIFCliente2 { get; private set; }

        [StringLength(50)]
        public string NomInstCliente2 { get; private set; }
        
    }
}