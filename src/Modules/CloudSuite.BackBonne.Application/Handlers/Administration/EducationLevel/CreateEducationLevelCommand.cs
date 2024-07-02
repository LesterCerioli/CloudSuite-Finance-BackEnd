using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Dependent.Reponses;
using CloudSuite.BackBonne.Application.Handlers.Administration.EducationLevel.Reponses;
using MediatR;
using EducationLevelEntity = CloudSuite.BackBonne.Domain.models.Administration.EducationLevel;

namespace CloudSuite.BackBonne.Application.Handlers.Administration.EducationLevel
{
    internal class CreateEducationLevelCommand : IRequest<CreateEducationLevelResponse>
    {
        public Guid Id { get; private set; }

        public CreateEducationLevelCommand()
        {
            Id = Guid.NewGuid();
        }

        public EducationLevelEntity GetEntity()
        {
            return new EducationLevelEntity(

            );

        }
    }
}