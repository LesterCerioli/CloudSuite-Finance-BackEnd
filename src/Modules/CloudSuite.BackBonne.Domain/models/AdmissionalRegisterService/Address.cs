using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Address : Entity, IAggregateRoot
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        [MaxLength(100)]
        public string Neighborhood { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public int? Number { get; set; }
        [MaxLength(255)]
        public string Complement { get; set; }

        public Address(int countryId, int stateId, int cityId, string neighborhood, string zipCode, string description, int? number, string complement)
        {
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            Description = description;
            Number = number;
            Complement = complement;
        }
    }
}