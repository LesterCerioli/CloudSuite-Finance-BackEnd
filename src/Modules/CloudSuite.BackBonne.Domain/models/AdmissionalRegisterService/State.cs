using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    namespace CloudSuite.BackBonne.Domain.models.Locations
    {
        public class State : Entity, IAggregateRoot
        {
            public State(int? stateId, string? name)
            {
                StateId = stateId;
                Name = name;
            }

            public State() { }

            public int? StateId { get; private set; }

            public string? Name { get; private set; }
        }
    }
}  