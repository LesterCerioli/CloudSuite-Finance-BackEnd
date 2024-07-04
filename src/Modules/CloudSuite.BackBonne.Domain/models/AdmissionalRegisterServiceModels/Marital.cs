using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
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
        public Marital(int? maritalStatus, DescriptionCommons description)
        {
            MaritalStatus = maritalStatus;
            Description = description;
        }
     
        public Marital() { }

        public int? MaritalStatus { get; private set; }

        public string? Description { get; private set; }



    }
}        