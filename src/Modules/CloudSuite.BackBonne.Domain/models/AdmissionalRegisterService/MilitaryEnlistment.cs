using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class MilitaryEnlistment : Entity
    {
        public int MilitaryEnlistmentId { get; private set; }
        public string Number { get; private set; }

        // Construtor padrão sem parâmetros
        protected MilitaryEnlistment() { }

        public MilitaryEnlistment(int militaryEnlistmentId, string number)
        {
            MilitaryEnlistmentId = militaryEnlistmentId;
            Number = number;
        }

        // Aqui poderiam ser adicionados métodos específicos de negócio relacionados ao alistamento militar, se necessário
    }
}