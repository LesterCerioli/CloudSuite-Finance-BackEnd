using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Request;
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Responses;
using CloudSuite.BackBonne.Domain.contracts.AsgardGold;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using CloudSuite.BackBonne.Application.Validations.UserClaim;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim
{
    public class CheckUserClaimByTypeHandler : IRequestHandler<CheckUserClaimByTypeRequest, CheckUserClaimByTypeResponse>
    {
        private readonly IUserClaimRepository _userClaimRepository;
        private readonly ILogger<CheckUserClaimByTypeHandler> _logger;

        public CheckUserClaimByTypeHandler(IUserClaimRepository userClaimRepository, ILogger<CheckUserClaimByTypeHandler> logger)
        {
            _userClaimRepository = userClaimRepository;
            _logger = logger;
        }

        public async Task<CheckUserClaimByTypeResponse> Handle(CheckUserClaimByTypeRequest command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckUserClaimByTypeRequest: {JsonSerializer.Serialize(command)}");
            var validationResult = new CheckUserClaimByTypeValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {
                    var UserClaimType = await _userClaimRepository.GetByType(command.Type);

                    if (UserClaimType != null)
                    {
                        return await Task.FromResult(new CheckUserClaimByTypeResponse(command.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckUserClaimByTypeResponse(command.Id, "Failed to process the request."));
                }
            }
            return await Task.FromResult(new CheckUserClaimByTypeResponse(command.Id, false, validationResult));
        }

    }
}
