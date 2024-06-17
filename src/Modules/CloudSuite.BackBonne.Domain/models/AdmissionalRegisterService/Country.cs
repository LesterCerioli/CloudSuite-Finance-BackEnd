using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Country : Entity, IAggregateRoot
    {
        public int CountryId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string Name { get; set; }

        public Country() { } // Construtor sem parâmetros

        public Country(int countryId, string name)
        {
            CountryId = countryId;
            Name = name;
        }
    }
}