using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class City : Entity, IAggregateRoot
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string Name { get; set; }

        public City() { } // Construtor sem parâmetros

        public City(int countryId, int stateId, int cityId, string name)
        {
            CountryId = countryId;
            StateId = stateId;
            CityId = cityId;
            Name = name;
        }
    }
}