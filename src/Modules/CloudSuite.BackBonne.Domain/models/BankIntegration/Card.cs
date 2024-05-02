using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class Card : Entity, IAggregateRoot
    {
        public string? CardHolderName { get; private set; }

        //public string? CardExternalAccountId { get; set; }

        public int? BankAgency { get; private set; }

        public int? BankAccount { get; private set; }

        public string? InsertUser { get; private set; }

        public string? CardServiceUser { get; private set; }

        public string? IdempotencyKey { get; private set; }

        public string? CardNumber { get; private set; }

        //Analyze possibility to receive a token number to validate card number
        //public string? SecretCode { get; private set; }

        public string? Token { get; private set; }
    }
}
