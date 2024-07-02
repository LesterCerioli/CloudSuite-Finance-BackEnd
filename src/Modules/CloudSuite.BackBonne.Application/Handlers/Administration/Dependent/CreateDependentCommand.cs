using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Country;
using CloudSuite.BackBonne.Application.Handlers.Administration.Dependent.Reponses;
using MediatR;
using DependentEntity = CloudSuite.BackBonne.Domain.models.Administration.Dependent;

namespace CloudSuite.BackBonne.Application.Handlers.Administration.Dependent
{
    public class CreateDependentCommand : IRequest<CreateDependentResponse>
    {
        public Guid Id { get; private set; }

        public CreateDependentCommand()
        {
            Id = Guid.NewGuid();
        }

        public DependentEntity GetEntity()
        {
            return new DependentEntity(

            );

        }
    }
}