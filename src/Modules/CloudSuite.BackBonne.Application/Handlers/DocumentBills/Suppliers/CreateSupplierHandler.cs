using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using CloudSuite.BackBonne.Application.Validations.Suppliers;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using CloudSuite.Modules.Common.Valueobjects;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers
{
    public class CreateSupplierHandler : IRequestHandler<CreateSupplierCommand, CreateSuppliersResponse>
    {
        private ISupplierRepository _repositorioSupplier;
        private readonly ILogger<CreateSupplierHandler> _logger;

        public CreateSupplierHandler(ISupplierRepository repositorioSupplier, ILogger<CreateSupplierHandler> logger)
        {
            _repositorioSupplier = repositorioSupplier;
            _logger = logger;
        }

        public async Task<CreateSuppliersResponse> Handle(CreateSupplierCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateSupplierCommand: {JsonSerializer.Serialize(command)}");
            var validationResult = new CreateSuppliersCommandValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {
                    var supplierCnpj = await _repositorioSupplier.GetByCnpj(new Cnpj(command.Cnpj));
                    var supplierName = await _repositorioSupplier.GetBySupplierName(command.SupplierName);

                    if (supplierCnpj != null && supplierName != null)
                    {
                        return await Task.FromResult(new CreateSuppliersResponse(command.Id, "Supplier já foi criado."));
                    }

                    await _repositorioSupplier.Add(command.GetEntity());
                    return await Task.FromResult(new CreateSuppliersResponse(command.Id, validationResult));
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CreateSuppliersResponse(command.Id, "Não foi possível processar a solicitação."));
                }
            }

            return await Task.FromResult(new CreateSuppliersResponse(command.Id, validationResult));
        }
    }
}
