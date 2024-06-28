using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Request;
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses;
using CloudSuite.BackBonne.Application.Validations.AsgardGold;
using CloudSuite.BackBonne.Domain.contracts.AsgardGold;
using CloudSuite.Modules.Cora.Application.Core;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;


namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser
{
    public class CheckAsgardGoldUserByEmailHandler : IRequestHandler<CheckAsgardGoldUserByEmailRequest, CheckAsgardGoldUserByEmailResponse>
    {
        private readonly IAsgardGoldUserRepository _asgardGoldUserRepository;
        private readonly ILogger<CheckAsgardGoldUserByEmailHandler> _logger;

        public CheckAsgardGoldUserByEmailHandler(IAsgardGoldUserRepository asgardGoldUserRepository, ILogger<CheckAsgardGoldUserByEmailHandler> logger)
        {
            _asgardGoldUserRepository = asgardGoldUserRepository;
            _logger = logger;
        }

        public async Task<CheckAsgardGoldUserByEmailResponse> Handle(CheckAsgardGoldUserByEmailRequest command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckAsgardGoldUserByEmailRequest: {JsonSerializer.Serialize(command)}");
            var validationResult = new CheckAsgardGoldUserByEmailValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {
                    var AsgardGoldUserEmail = await _asgardGoldUserRepository.GetByEmail(command.Email);
                   
                    if (AsgardGoldUserEmail != null)
                    {
                        return await Task.FromResult(new CheckAsgardGoldUserByEmailResponse(command.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckAsgardGoldUserByEmailResponse(command.Id, "Failed to process the request."));
                }
            }
            return await Task.FromResult(new CheckAsgardGoldUserByEmailResponse(command.Id, false, validationResult));
        }

    }
}
