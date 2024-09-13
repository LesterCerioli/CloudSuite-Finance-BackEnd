using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class EducationLevel : Entity, IAggregateRoot
    {
        public EducationLevel(string? description, string? educationLevelName)
        {
            Description = description;
            EducationLevelName = educationLevelName;
        }

        public string? EducationLevelName { get; private set; }
        
        public string? Description { get; private set; }
    }
}
