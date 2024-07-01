using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BPC
{
    public class Transaction : Entity, IAggregateRoot
    {
        public string? CompanyCode { get; private set; }
        
        public string? SystemCode { get; private set; }
        
        public DateTime? Date { get; private set; }
        
        public int? IntegrationCode { get; private set; }
        
        public string? ClientCode { get; private set; }
        
        public string? Counterparty { get; private set; }
        
        public DateTime? SettlementDate { get; private set; }
        
        public int? WalletType { get; private set; }
        
        public int? Category { get; private set; }
        
        public int? OperationType { get; private set; }
        
        public double? Quantity { get; private set; }
        
        public double? Value { get; private set; }
        
        public double? TotalValue { get; private set; }
        
        public double? IndexOperPerc { get; private set; }
        
        public double? Rate { get; private set; }
        
        public int? RateType { get; private set; }
        
        public int? ClearingSequence { get; private set; }

        public DateTime? ApplicationDate { get; private set; }

        public int? BlockReason { get; private set; }

        public DateTime? BackDate { get; private set; }

        public double? BackQuantity { get; private set; }

        public double BackTotalValue { get; set; }

        public string? CustodianCode { get; private set; }

        public DateTime? DurationDate { get; private set; }

        public int? CalculateOperCode { get; private set; }

        public int AdmSeqSettlementType { get; set; }

        public string? CodeIDIFCustomer2 { get; private set; }

        public int? CustomerOpenType { get; private set; }

        public string? IntOperatorCode { get; set; }

        public int? RedemptionOpenType { get; private set; }

        public string? StaTLM { get; private set; }

        public string? StaIntermediation { get; private set; }

        public string? StaValidNetCC { get; private set; }

        public string? DesTpoTransactionStatus { get; private set; }

        public string? DesOperationType { get; private set; }

        public string? FinancialInstrumentAbbreviation { get; private set; }

        public string? DesCalculateOperCode { get; private set; }

        public string? DesWalletType { get; private set; }

        public string? DesCategoryType { get; private set; }

        public string? InstCustomerName2 { get; private set; } // Fixed typo here

        public DateTime? RegistryDate { get; private set; }
    }
}
