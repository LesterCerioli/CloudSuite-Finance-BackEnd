﻿using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses
{
    public class CreateInvoiceResponse : Response
    {
        public Guid RequestId { get; private set; }

        public CreateInvoiceResponse(Guid requestId, ValidationResult result)
        {
            RequestId = requestId;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CreateInvoiceResponse(Guid requestId, string falhaValidacao)
        {
            RequestId = requestId;
            this.AddError(falhaValidacao);
        }
    }
}