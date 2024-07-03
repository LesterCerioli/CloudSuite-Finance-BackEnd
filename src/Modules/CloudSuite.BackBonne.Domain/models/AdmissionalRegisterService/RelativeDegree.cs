using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class RelativeDegree : Entity, IAggregateRoot
    {
        public RelativeDegree( DescriptionCommons description)
        {
            Description = description;
        }
       
        public RelativeDegree() { }

        public string Description { get; set; }


    }
}
    