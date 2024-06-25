using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Validations.Suppliers
{
    public class CheckSuppliersExistsBySupplierNameRequestValidation : AbstractValidator<CheckSuppliersExistsBySupplierNameRequest>
    {
        public CheckSuppliersExistsBySupplierNameRequestValidation()
        {
            RuleFor(a => a.SupplierName)
                .NotEmpty()
                .WithMessage("O campo SupplierName é obrigatório.")
                .Length(1, 100)
                .WithMessage("O campo SupplierName deve ter entre 1 e 100 caracteres.")
                .Matches(@"^[a-zA-Z\s]*$")
                .WithMessage("O campo SupplierName deve conter apenas letras e espaços.")
                .NotNull()
                .WithMessage("O campo SupplierName não pode ser nulo.");
        }
    }
}
