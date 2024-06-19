using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses
{
    public class CheckInvoiceExistsPaymentDateResponse : Response
    {
        public Guid Id { get; private set; }
        public bool Exists { get; set; }

        public CheckInvoiceExistsPaymentDateResponse(Guid id, bool exists, ValidationResult result)
        {
            Id = id;
            Exists = exists;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CheckInvoiceExistsPaymentDateResponse(Guid id, string falhaValidacao)
        {
            Id = id;
            Exists = false;
            this.AddError(falhaValidacao);
        }
    }
}
