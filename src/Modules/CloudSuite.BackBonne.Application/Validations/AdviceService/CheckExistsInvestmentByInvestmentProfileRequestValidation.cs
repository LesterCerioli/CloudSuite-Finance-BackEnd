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
    public class CheckExistsInvestmentByInvestmentProfileRequestValidation : AbstractValidator<CheckExistsInvestmentByInvestmentProfileRequest>
    {

        public CheckExistsInvestmentByInvestmentProfileRequestValidation()
        {
            RuleFor(c => c.InvestmentProfile)
            .NotEmpty()
            .WithMessage("Perfil de investimento é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Perfil de investimento deve ter no mínimo 1 caracter.");
        }
    }
}