using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.City;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.Administration.Address
{
    public class CreateCityCommandValidation : AbstractValidator<CreateCityCommand>
    {
        public CreateCityCommandValidation()
        {

        }
    }
}
