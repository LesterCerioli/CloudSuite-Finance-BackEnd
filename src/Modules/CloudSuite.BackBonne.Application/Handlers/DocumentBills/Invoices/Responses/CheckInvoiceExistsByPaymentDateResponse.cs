﻿using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses
{
    public class CheckInvoiceExistsPaymentDateResponse : Response
    {
        public Guid RequestId { get; private set; }
        public bool Exists { get; set; }

        public CheckInvoiceExistsPaymentDateResponse(Guid requestId, bool exists, ValidationResult result)
        {
            RequestId = requestId;
            Exists = exists;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CheckInvoiceExistsPaymentDateResponse(Guid requestId, string falhaValidacao)
        {
            RequestId = requestId;
            Exists = false;
            this.AddError(falhaValidacao);
        }
    }
}