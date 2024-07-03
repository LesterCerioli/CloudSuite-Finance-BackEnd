using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using FluentValidation;
using MediatR;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests
{
    public class CheckExistsInvestmentByTaxPayerRegistryRequestValidation : AbstractValidator<CheckExistsInvestmentByTaxPayerRegistryRequest>
    {

        public CheckExistsInvestmentByTaxPayerRegistryRequestValidation()
        {
            RuleFor(c => c.TaxPayerRegistry)
            .NotEmpty()
            .WithMessage("Campo de Registro de pagador de imposto é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Campo de Registro de pagador de imposto deve ter no mínimo 1 caracter.");
        }
    }
}