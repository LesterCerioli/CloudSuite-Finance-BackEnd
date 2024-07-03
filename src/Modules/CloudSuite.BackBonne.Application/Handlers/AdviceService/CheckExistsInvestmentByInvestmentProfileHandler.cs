using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Requests;
using CloudSuite.BackBonne.Application.Handlers.AdviceService.Responses;
using CloudSuite.BackBonne.Domain.contracts;
using CloudSuite.BackBonne.Domain.models.AdviceService;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CloudSuite.BackBonne.Application.Handlers.AdviceService
{
    public class CheckExistsInvestmentByInvestmentProfileHandler : IRequestHandler<CheckExistsInvestmentByInvestmentProfileRequest, CheckExistsInvestmentByInvestmentProfileResponse>
    {

        private IInvestmentRepository _investmentRepository;
        private readonly ILogger<CheckExistsInvestmentByInvestmentProfileHandler> _logger;

        public CheckExistsInvestmentByInvestmentProfileHandler(IInvestmentRepository investmentRepository, ILogger<CheckExistsInvestmentByInvestmentProfileHandler> logger)
        {
            _investmentRepository = investmentRepository;
            _logger = logger;
        }

        public async Task<CheckExistsInvestmentByInvestmentProfileResponse> Handle(CheckExistsInvestmentByInvestmentProfileRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckExistsInvestmentByInvestmentProfileRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckExistsInvestmentByInvestmentProfileRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var investmentProfile = await _investmentRepository.GetByInvestmentProfile(request.InvestmentProfile);


                    if (investmentProfile != null)
                    {
                        return await Task.FromResult(new CheckExistsInvestmentByInvestmentProfileResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckExistsInvestmentByInvestmentProfileResponse(request.Id, "Failed to process the request."));
                }
            }
            return await Task.FromResult(new CheckExistsInvestmentByInvestmentProfileResponse(request.Id, false, validationResult));
        }
    }
}