using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class CityEntity : Entity, IAggregateRoot
    {
        public CityEntity(int countryId, int stateId, int cityId, string name)
        {
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
            Name = name;
        }

        public CityEntity() { }

        public int CountryId { get; private set; }

        public int StateId { get; private set; }

        public int CityId { get; private set; }

        public string Name { get; private set; }
    }
}