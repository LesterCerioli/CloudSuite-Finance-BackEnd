using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class StateModel : Entity, IAggregateRoot
    {
        public int StateId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string Name { get; set; }

        public StateModel(int stateId, string name)
        {
            StateId = stateId;
            Name = name;
        }
    }
}