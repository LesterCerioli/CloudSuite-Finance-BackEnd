using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using CloudSuite.BackBonne.Application.Validations.AdviceService;
using CloudSuite.BackBonne.Domain.contracts;
using CloudSuite.BackBonne.Domain.models.AdviceService;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService
{
    public class CreateInvestmentHandler : IRequestHandler<CreateInvestmentCommand, CreateInvestmentResponse>
    {
        private readonly IInvestmentRepository _investmentRepository;
        private readonly ILogger<CreateInvestmentHandler> _logger;

        public CreateInvestmentHandler(IInvestmentRepository investmentRepository, ILogger<CreateInvestmentHandler> logger)
        {
            _investmentRepository = investmentRepository;
            _logger = logger;
        }

        public async Task<CreateInvestmentResponse> Handle(CreateInvestmentCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateInvestmentCommand: {JsonSerializer.Serialize(command)}");

            var validationResult = new CreateInvestmentCommandValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {

                    var investment = command.GetEntity();

                    var taxPayerRegistryExists = await _investmentRepository.GetByTaxPayerRegistry(investment.TaxPayerRegistry);
                    var nameExists = await _investmentRepository.GetByName(investment.Name);
                    var investmentProfileExists = await _investmentRepository.GetByInvestmentProfile(investment.InvestmentProfile);

                    if (taxPayerRegistryExists == null && nameExists == null && investmentProfileExists == null)
                    {
                        await _investmentRepository.Add(investment);
                        return await Task.FromResult(new CreateInvestmentResponse(command.Id, validationResult));
                    }
                    else
                    {
                        return await Task.FromResult(new CreateInvestmentResponse(command.Id, "Investment already exists."));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"An error occurred during account creation: {ex.Message}");
                    return await Task.FromResult(new CreateInvestmentResponse(command.Id, "Failed to process the request."));
                }
            }

            return await Task.FromResult(new CreateInvestmentResponse(command.Id, validationResult));
        }
    }
}