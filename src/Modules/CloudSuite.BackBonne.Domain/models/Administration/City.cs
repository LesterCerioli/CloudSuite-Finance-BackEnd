using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class City : Entity, IAggregateRoot
    {
        public City(string? cityName)
        {
            CityName = cityName;
            _states = new List<State>();
        }

        public string? CityName { get; private set; }

        private readonly List<State> _states;

        public State State { get; set; }

        public Guid StateId { get; set; }

        public IReadOnlyCollection<State> States => _states.AsReadOnly();
    }
}
