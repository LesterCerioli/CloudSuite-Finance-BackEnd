using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BPC
{
    public class Provision : Entity, IAggregateRoot
    {


        
        public Provision() {}
        
        public DateTime? DataExecucao { get; private set; }

        public string? Clearing { get; private set; }

        public string? Historico { get; private set; }

        public decimal? ValorPrevisto { get; private set; }

        public string? Status { get; private set; }

        public string? NomeContraparte { get; private set; }
        
    }
}