using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class BankDetails : Entity, IAggregateRoot
    {
        public BankDetails(int bankId, string name)
        {
            BankId = bankId;
            Name = name;
        }

        public BankDetails() { }

        public int BankId { get; private set; }

        public string Name { get; private set; }
    }
}   
  