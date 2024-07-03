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
    public class CheckExistsInvestmentByNameHandler : IRequestHandler<CheckExistsInvestmentByNameRequest, CheckExistsInvestmentByNameResponse>
    {

        private IInvestmentRepository _investmentRepository;
        private readonly ILogger<CheckExistsInvestmentByNameHandler> _logger;

        public CheckExistsInvestmentByNameHandler(IInvestmentRepository investmentRepository, ILogger<CheckExistsInvestmentByNameHandler> logger)
        {
            _investmentRepository = investmentRepository;
            _logger = logger;
        }

        public async Task<CheckExistsInvestmentByNameResponse> Handle(CheckExistsInvestmentByNameRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckExistsInvestmentByNameRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckExistsInvestmentByNameRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var name = await _investmentRepository.GetByName(request.Name);


                    if (name != null)
                    {
                        return await Task.FromResult(new CheckExistsInvestmentByNameResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckExistsInvestmentByNameResponse(request.Id, "Failed to process the request."));
                }
            }
            return await Task.FromResult(new CheckExistsInvestmentByNameResponse(request.Id, false, validationResult));
        }
    }
}