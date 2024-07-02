using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.EducationLevel.Reponses;
using CloudSuite.BackBonne.Application.Handlers.Administration.State.Reponses;
using MediatR;
using StateEntity = CloudSuite.BackBonne.Domain.models.Administration.State;


namespace CloudSuite.BackBonne.Application.Handlers.Administration.State
{
    public class CreateStateCommand : IRequest<CreateStateResponse>
    {
        public Guid Id { get; private set; }

        public CreateStateCommand()
        {
            Id = Guid.NewGuid();
        }

        public StateEntity GetEntity()
        {
            return new StateEntity(

            );

        }
    }
}