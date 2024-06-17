using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class BankAccount : Entity, IAggregateRoot
    {
        public int? BankId { get; set; }
        [MaxLength(20)]
        public string Branch { get; set; }
        [MaxLength(2)]
        public string BranchDigit { get; set; }
        [MaxLength(20)]
        public string Account { get; set; }
        [MaxLength(2)]
        public string AccountDigit { get; set; }

        public BankAccount(int? bankId, string branch, string branchDigit, string account, string accountDigit)
        {
            BankId = bankId;
            Branch = branch;
            BranchDigit = branchDigit;
            Account = account;
            AccountDigit = accountDigit;
        }
    }
}