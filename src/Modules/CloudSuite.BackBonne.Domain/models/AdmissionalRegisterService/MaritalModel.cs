using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class MaritalModel : Entity, IAggregateRoot
    {
        public int MaritalStatusId { get; private set; }
        public string Description { get; private set; }

        // Construtor padrão sem parâmetros
        protected MaritalModel() { }

        public MaritalModel(int maritalStatusId, string description)
        {
            MaritalStatusId = maritalStatusId;
            Description = description;
        }

        // Aqui poderiam ser adicionados métodos específicos de negócio relacionados ao estado civil, se necessário
    }
}