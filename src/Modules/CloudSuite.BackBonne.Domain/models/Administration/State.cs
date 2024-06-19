using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class State : Entity, IAggregateRoot
    {
        public State(string? stateName)
        {
            StateName = stateName;
            _cities = new List<City>();
        }

        public string? StateName { get; private set; }

        private readonly List<City> _cities;

        public Guid CountryId { get; private set; }

        public IReadOnlyCollection<City> Cities => _cities.AsReadOnly();
    }
}
