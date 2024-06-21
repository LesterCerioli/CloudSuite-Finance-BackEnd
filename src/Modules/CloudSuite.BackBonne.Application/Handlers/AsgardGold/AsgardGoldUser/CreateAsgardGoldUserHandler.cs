using CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser.Responses;
using CloudSuite.BackBonne.Application.Validations.AsgardGold;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.Handlers.AsgardGold.AsgardGoldUser
{
    public class CreateAsgardGoldUserHandler : IRequestHandler<CreateAsgardGoldUserCommand, CreateAsgardGoldUserResponse>
    {
        private IAsgardGoldUserRepository _asgardGoldUserRepository;
        private readonly ILogger<CreateAsgardGoldUserHandler> _logger;

        public CreateAsgardGoldUserHandler(IAsgardGoldUserRepository asgardGoldUserRepository, ILogger<CreateAsgardGoldUserHandler> logger)
        {
            _asgardGoldUserRepository = asgardGoldUserRepository;
            _logger = logger;

        }
        public async Task<CreateAsgardGoldUserResponse> Handle(CreateAsgardGoldUserCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateUserCommand: {JsonSerializer.Serialize(command)}");
            var validationResult = new CreateAsgardGoldUserValidation().Validate(command);
            if (validationResult.IsValid)
            {
                try
                {
                    //var municipalRegister = await _asgardGoldUserRepository.GetByMunicipalRegister(command.Municipal_register);
                    //var taxRegime = await _asgardGoldUserRepository.GetBySpecialTaxRegime(command.Tax_regime);

                    if (municipalRegister != null && taxRegime != null && specialTaxRegime != null)
                    {
                        return await Task.FromResult(new CreateAsgardGoldUserResponse(command.Id, "User already registered."));
                    }
                    await _asgardGoldUserRepository.Add(command.GetEntity());
                    return await Task.FromResult(new CreateAsgardGoldUserResponse(command.Id, validationResult));
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CreateAsgardGoldUserResponse(command.Id, "Failed to process the request."));
                }

            }
            return await Task.FromResult(new CreateAsgardGoldUserResponse(command.Id, validationResult));

        }
}
