using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using CloudSuite.BackBonne.Domain.models.AdviceService;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService
{
    public class CheckExistsInvestmentByTaxPayerRegistryHandler : IRequestHandler<CheckExistsInvestmentByTaxPayerRegistryRequest, CheckExistsInvestmentByTaxPayerRegistryResponse>
    {

        private IInvestmentRepository _investmentRepository;
        private readonly ILogger<CheckExistsInvestmentByTaxPayerRegistryHandler> _logger;

        public CheckExistsInvestmentByTaxPayerRegistryHandler(IInvestmentRepository investmentRepository, ILogger<CheckExistsInvestmentByTaxPayerRegistryHandler> logger)
        {
            _investmentRepository = investmentRepository;
            _logger = logger;
        }

        public async Task<CheckExistsInvestmentByTaxPayerRegistryResponse> Handle(CheckExistsInvestmentByTaxPayerRegistryRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckExistsInvestmentByTaxPayerRegistryRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckExistsInvestmentByTaxPayerRegistryRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var taxPayerRegistry = await _investmentRepository.GetByTaxPayerRegistry(request.TaxPayerRegistry);


                    if (taxPayerRegistry != null)
                    {
                        return await Task.FromResult(new CheckExistsInvestmentByTaxPayerRegistryResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckExistsInvestmentByTaxPayerRegistryResponse(request.Id, "Failed to process the request."));
                }
            }
            return await Task.FromResult(new CheckExistsInvestmentByTaxPayerRegistryResponse(request.Id, false, validationResult));
        }
    }
}