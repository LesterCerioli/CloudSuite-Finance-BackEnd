using CloudSuite.BackBonne.Domain.models.Administration;
using CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService.CloudSuite.BackBonne.Domain.models.Locations;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using State = CloudSuite.BackBonne.Domain.models.Administration.State;

namespace AdmissionalRegisterService.Model
{
    public class Country : Entity, IAggregateRoot
    {
        private readonly List<State> _states;

        public Country( string? name)
        {
            Name = name;
            _states = new List<State>();
        }

        public Country() { }

        public string?  Name { get; private set; } 
        public IReadOnlyCollection<State> State => _states.AsReadOnly();
    }
}

  