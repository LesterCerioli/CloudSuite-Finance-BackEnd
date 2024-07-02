using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.Dependent;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.Administration.Address
{
    public class CreateDependentCommandValidation : AbstractValidator<CreateDependentCommand>
    {
        public CreateDependentCommandValidation()
        {

        }
    }
}
