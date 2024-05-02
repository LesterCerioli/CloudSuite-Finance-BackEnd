using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class BankAccountBlocked : Entity, IAggregateRoot
    {
        public BankAccountBlocked(string? description, DateTime? initialDate)
        {
            Description = description;
            InitialDate = DateTime.Now;
            _dataBanks = new List<DataBank>();
        }

        public string? Description { get; private set; }

        public DateTime? InitialDate { get; private set; }

        private readonly List<DataBank> _dataBanks;

        public DataBank DataBank { get; private set; }

        public IReadOnlyCollection<DataBank> DataBanks => _dataBanks.ToArray();
    }
}
