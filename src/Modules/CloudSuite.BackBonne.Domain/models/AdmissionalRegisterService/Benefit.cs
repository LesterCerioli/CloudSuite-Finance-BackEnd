using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Benefit : Entity, IAggregateRoot
    {
        public int BenefitId { get; set; }
        public int Type { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public decimal Value { get; set; }

        public Benefit() { } // Construtor sem parâmetros

        public Benefit(int benefitId, int type, string description, decimal value)
        {
            BenefitId = benefitId;
            Type = type;
            Description = description;
            Value = value;
        }
    }
}