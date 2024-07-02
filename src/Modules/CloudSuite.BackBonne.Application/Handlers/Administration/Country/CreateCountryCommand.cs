using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Country.Reponses;
using MediatR;
using CountryEntity = CloudSuite.BackBonne.Domain.models.Administration.Country;

namespace CloudSuite.BackBonne.Application.Handlers.Administration.Country
{
    public class CreateCountryCommand : IRequest<CreateCountryResponse>
    {
        public Guid Id { get; private set; }

        public CreateCountryCommand()
        {
            Id = Guid.NewGuid();
        }

        public CountryEntity GetEntity()
        {
            return new CountryEntity(

            );

        }
    }
}