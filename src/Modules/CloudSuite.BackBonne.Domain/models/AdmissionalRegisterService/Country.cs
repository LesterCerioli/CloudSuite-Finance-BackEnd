using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class CountryEntity : Entity, IAggregateRoot
    {
        public CountryEntity(int? countryId, string? name)
        {
            CountryId = countryId;
            Name = name;
        }

        public CountryEntity() { }

        public int? CountryId { get; private set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string?  Name { get; private set; }
    }
}

 