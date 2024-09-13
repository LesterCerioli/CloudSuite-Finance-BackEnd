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
        public EducationLevel(string? description)
        {
            Description = description;
        }

        public string? Description { get; private set; }
    }
}
