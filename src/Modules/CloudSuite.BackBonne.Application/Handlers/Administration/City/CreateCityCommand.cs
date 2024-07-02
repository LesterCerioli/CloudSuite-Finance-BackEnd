using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.City.Reponses;
using MediatR;
using CityEntity = CloudSuite.BackBonne.Domain.models.Administration.City;


namespace CloudSuite.BackBonne.Application.Handlers.Administration.City
{
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        public Guid Id { get; private set; }

        public CreateCityCommand()
        {
            Id = Guid.NewGuid();
        }

        public CityEntity GetEntity()
        {
            return new CityEntity(

            );

        }
    }
}