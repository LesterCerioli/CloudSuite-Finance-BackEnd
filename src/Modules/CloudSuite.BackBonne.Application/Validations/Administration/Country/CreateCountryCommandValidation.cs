using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Country;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.Administration.Address
{
    public class CreateCountryCommandValidation : AbstractValidator<CreateCountryCommand>
    {
        public CreateCountryCommandValidation()
        {

        }
    }
}
