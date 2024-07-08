using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService;
using FluentValidation;

namespace CloudSuite.BackBonne.Application.Validations.AdviceService
{
    public class CreateInvestmentCommandValidation : AbstractValidator<CreateInvestmentCommand>
    {
        public CreateInvestmentCommandValidation()
        {
            RuleFor(c => c.TaxPayerRegistry)
            .NotEmpty()
            .WithMessage("Campo de Registro de pagador de imposto é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Campo de Registro de pagador de imposto deve ter no mínimo 1 caracter.");

            RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("Campo de nome é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Nome deve ter no mínimo 1 caracter.");

            RuleFor(c => c.InvestmentProfile)
            .NotEmpty()
            .WithMessage("Perfil de investimento é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Perfil de investimento deve ter no mínimo 1 caracter.");
        }
    }
}
