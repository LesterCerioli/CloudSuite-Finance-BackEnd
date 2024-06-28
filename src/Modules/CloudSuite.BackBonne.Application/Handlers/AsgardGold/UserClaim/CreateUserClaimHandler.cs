using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim.Responses;
using CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim;
using CloudSuite.BackBonne.Application.Validations.AsgardGold;
using CloudSuite.BackBonne.Domain.contracts.AsgardGold;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using CloudSuite.BackBonne.Application.Validations.UserClaim;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.UserClaim
{
    public class CreateUserClaimHandler : IRequestHandler<CreateUserClaimCommand, CreateUserClaimResponse>
    {
        private IUserClaimRepository _userClaimRepository;
        private readonly ILogger<CreateUserClaimHandler> _logger;

        public CreateUserClaimHandler(IUserClaimRepository userClaimRepository, ILogger<CreateUserClaimHandler> logger)
        {
            _userClaimRepository = userClaimRepository;
            _logger = logger;

        }
        public async Task<CreateUserClaimResponse> Handle(CreateUserClaimCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateUserClaimCommand: {JsonSerializer.Serialize(command)}");
            var validationResult = new CreateUserClaimValidation().Validate(command);
            if (validationResult.IsValid)
            {
                try
                {

                    var UserClaimEmail = await _userClaimRepository.GetByType(command.Type);

                    if (UserClaimEmail != null)
                    {
                        return await Task.FromResult(new CreateUserClaimResponse(command.Id, "User already registered."));
                    }
                    await _userClaimRepository.Add(command.GetEntity());
                    return await Task.FromResult(new CreateUserClaimResponse(command.Id, validationResult));
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CreateUserClaimResponse(command.Id, "Failed to process the request."));
                }

            }
            return await Task.FromResult(new CreateUserClaimResponse(command.Id, validationResult));

        }

    }
}
