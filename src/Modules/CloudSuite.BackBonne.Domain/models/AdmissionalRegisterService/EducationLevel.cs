using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class EducationLevel : Entity, IAggregateRoot
    {
        public EducationLevel(int? educationLevelId, string? description)
        {
            EducationLevelId = educationLevelId;
            Description = description;
        }
      
        public EducationLevel() { }

        public int? EducationLevelId { get; private set; }
        public string? Description { get; private set; }

    }
}   