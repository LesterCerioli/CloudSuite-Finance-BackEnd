using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using CloudSuite.Modules.Commons.ValueObject;
using CloudSuite.Modules.Commons.ValueObjects;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
                    var invoice = await _repositorioSupplier.GetByCnpj(new CNPJ(request.Cnpj));
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
