using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.Administration.EducationLevel.Reponses
{
    public class CreateEducationLevelResponse : Response
    {
        public Guid RequestId { get; private set; }

        public CreateEducationLevelResponse(Guid requestId, ValidationResult result)
        {
            RequestId = requestId;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }
        public CreateEducationLevelResponse(Guid requestId, string falhaValidacao)
        {
            RequestId = requestId;
            this.AddError(falhaValidacao);
        }
    }
}