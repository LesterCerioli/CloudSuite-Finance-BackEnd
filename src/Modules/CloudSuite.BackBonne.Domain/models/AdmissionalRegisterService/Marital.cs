using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class Marital : Entity, IAggregateRoot
    {
        public Marital(int maritalStatusId, string description)
        {
            MaritalStatusId = maritalStatusId;
            Description = description;
        }
     
        public Marital() { }

        public int MaritalStatusId { get; private set; }

        public string Description { get; private set; }



    }
}      