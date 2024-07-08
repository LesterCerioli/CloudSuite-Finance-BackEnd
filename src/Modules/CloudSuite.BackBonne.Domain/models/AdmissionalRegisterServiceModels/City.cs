using CloudSuite.BackBonne.Domain.models.Administration;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class City : Entity, IAggregateRoot
    {

        private readonly List<State> _states;
        public City(State state, string? name)
        {
            State = state;
            Name = name; 
            _states = new List<State>();
        }

        public City() { }

        public State State { get; set; }

        public string? Name { get; private set; }

        public IReadOnlyCollection<State> States => _states.AsReadOnly();

    }
} 