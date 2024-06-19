using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses
{
    public class CheckInvoiceExistsByAmountResponse : Response
    {
        public Guid Id {  get; private set; }
        public bool Exists { get; set; }

        public CheckInvoiceExistsByAmountResponse(Guid id, bool exists, ValidationResult result)
        {
            Id = id;
            Exists = exists;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CheckInvoiceExistsByAmountResponse(Guid id, string falhaValidacao)
        {
            Id = id;
            Exists = false;
            this.AddError(falhaValidacao);
        }
    }
}
