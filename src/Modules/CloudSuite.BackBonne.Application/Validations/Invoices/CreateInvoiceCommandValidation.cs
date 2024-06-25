using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.Invoices
{
    public class CreateInvoiceCommandValidation : AbstractValidator<CreateInvoiceCommand>
    {
        public CreateInvoiceCommandValidation()
        {
            RuleFor(i => i.Amount)
                .NotNull()
                .WithMessage("O campo é obrigatório.")
                .NotEmpty()
                .WithMessage("O campo não pode estar vazio.")
                .GreaterThan(0)
                .WithMessage("O valor pago deve ser maior ou igual a 0.");

            RuleFor(i => i.DueDate)
               .GreaterThanOrEqualTo(DateTime.Now)
               .WithMessage("O campo ExpireDate deve ser uma data futura ou presente.");

            RuleFor(i => i.InvoiceStatus)
                .IsInEnum()
                .NotNull()
                .WithMessage("O campo de Método de Pagamento é Obrigatório");
        }
    }
}
