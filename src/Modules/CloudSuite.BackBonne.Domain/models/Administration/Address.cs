using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class Address : Entity, IAggregateRoot
    {
        public Address(string addressLine, string? neighborhood, string? zipCode, string? description, int? number, 
        string? complement)
        {
            AddressLine = addressLine;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            Description = description;
            Number = number;
            Complement = complement;
            _countries = new List<Country>();
            _states = new List<State>();
            _cities = new List<City>();
        }

        public string? AddressLine { get; private set; }
        
        public string? Neighborhood { get; private set; }

        public string? ZipCode { get; private set; }

        public string? Description { get; private set; }

        public int? Number { get; private set; }

        public string? Complement { get; private set; }

        private readonly List<Country> _countries;
        private readonly List<State> _states;
        private readonly List<City> _cities;

        public Country Country { get; private set; }

        public IReadOnlyCollection<Country> Countries => _countries.AsReadOnly();

        public State State { get; private set; }

        public IReadOnlyCollection<State> States => _states.AsReadOnly();

        public City City { get; private set; }

        public IReadOnlyCollection<City> Cities => _cities.AsReadOnly();
    }
}
