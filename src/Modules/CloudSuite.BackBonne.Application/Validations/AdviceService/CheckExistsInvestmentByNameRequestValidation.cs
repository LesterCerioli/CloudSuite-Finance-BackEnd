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
    public class CheckExistsInvestmentByNameRequestValidation : AbstractValidator<CheckExistsInvestmentByNameRequest>
    {

        public CheckExistsInvestmentByNameRequestValidation()
        {
            RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("Campo de nome é obrigatório.")
            .MinimumLength(1)
            .WithMessage("Nome deve ter no mínimo 1 caracter.");
        }
    }
}