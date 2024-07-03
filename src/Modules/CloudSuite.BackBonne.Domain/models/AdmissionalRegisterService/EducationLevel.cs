using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class EducationLevel : Entity, IAggregateRoot
    {
        public EducationLevel( DescriptionCommons description)
        {
            Description = description;
        }
      
        public EducationLevel() { }

        public string? Description { get; private set; }

    }
}    