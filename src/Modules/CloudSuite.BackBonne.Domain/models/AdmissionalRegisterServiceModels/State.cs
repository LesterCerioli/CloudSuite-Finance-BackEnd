using AdmissionalRegisterService.Model;
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
            private readonly List<Country> _countries;
            public State(Country country, string? name)
            {
                Name = name;
                Country = country;
                _countries = new List<Country>();  
            }

            public State() { }

            public string? Name { get; private set; } 

            public Country Country { get; private set; }

            public IReadOnlyCollection<Country> Countries => _countries.AsReadOnly();
        }
    }
}   