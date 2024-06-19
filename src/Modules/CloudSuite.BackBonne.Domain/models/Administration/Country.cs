using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class Country : Entity, IAggregateRoot
    {
        public Country(string? countryName)
        {
            CountryName = countryName;
            _states = new List<State>();
        }

        public string? CountryName { get; private set; }

        private readonly List<State> _states;

        public IReadOnlyCollection<State> States => _states.AsReadOnly();
    }
}
