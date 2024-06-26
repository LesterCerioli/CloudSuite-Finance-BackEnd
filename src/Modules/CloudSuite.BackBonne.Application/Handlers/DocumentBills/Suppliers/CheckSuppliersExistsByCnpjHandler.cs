using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using CloudSuite.BackBonne.Application.Validations.Suppliers;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using CloudSuite.Modules.Common.Valueobjects;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers
{
    public class CheckSuppliersExistsByCnpjHandler : IRequestHandler<CheckSuppliersExistsByCnpjRequest, CheckSuppliersExistsByCnpjResponse>
    {
        private ISupplierRepository _repositorioSupplier;
        private readonly ILogger<CheckSuppliersExistsByCnpjHandler> _logger;

        public CheckSuppliersExistsByCnpjHandler(ISupplierRepository repositorioSupplier, ILogger<CheckSuppliersExistsByCnpjHandler> logger)
        {
            _repositorioSupplier = repositorioSupplier;
            _logger = logger;
        }

        public async Task<CheckSuppliersExistsByCnpjResponse> Handle(CheckSuppliersExistsByCnpjRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckSuppliersExistsByCnpjRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckSuppliersExistsByCnpjRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioSupplier.GetByCnpj(new Cnpj(request.Cnpj));
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckSuppliersExistsByCnpjResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckSuppliersExistsByCnpjResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckSuppliersExistsByCnpjResponse(request.Id, false, validationResult));
        }
    }
}
