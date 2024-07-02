using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.Administration.EducationLevel;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.Administration.Address
{
    public class CreateEducationLevelCommandValidation : AbstractValidator<CreateEducationLevelCommand>
    {
        public CreateEducationLevelCommandValidation()
        {

        }
    }
}
