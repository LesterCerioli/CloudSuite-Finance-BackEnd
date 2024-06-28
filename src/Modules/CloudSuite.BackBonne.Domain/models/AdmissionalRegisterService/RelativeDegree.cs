using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class RelativeDegree : Entity, IAggregateRoot
    {
        public int RelativeDegreeId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(255)]

        public string Description { get; set; }

        public RelativeDegree() { } 

        public RelativeDegree(int relativeDegreeId, string description)
        {
            RelativeDegreeId = relativeDegreeId;
            Description = description;
        }
    }
}
  