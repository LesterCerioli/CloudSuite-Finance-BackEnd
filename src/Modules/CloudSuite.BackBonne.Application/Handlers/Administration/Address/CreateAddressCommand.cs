using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Address.Reponses;
using MediatR;
using AddressEntity = CloudSuite.BackBonne.Domain.models.Administration.Address;

namespace CloudSuite.BackBonne.Application.Handlers.Administration.Address
{
    public class CreateAddressCommand : IRequest<CreateAddressResponse>
    {
        public Guid Id { get; private set; }

        public CreateAddressCommand()
        {
            Id = Guid.NewGuid();
        }

        public AddressEntity GetEntity()
        {
            return new AddressEntity(
                
            );

        }
    }
}
