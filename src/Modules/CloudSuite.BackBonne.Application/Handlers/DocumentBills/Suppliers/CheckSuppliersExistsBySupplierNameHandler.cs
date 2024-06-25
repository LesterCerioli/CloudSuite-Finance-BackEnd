using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Suppliers
{
    public class CheckSuppliersExistsBySupplierNameHandler : IRequestHandler<CheckSuppliersExistsBySupplierNameRequest, CheckSuppliersExistsBySupplierNameResponse>
    {

        private ISupplierRepository _repositorioSuppliers;
        private readonly ILogger<CheckSuppliersExistsBySupplierNameHandler> _logger;

        public CheckSuppliersExistsBySupplierNameHandler(ISupplierRepository repositorioSuppliers, ILogger<CheckSuppliersExistsBySupplierNameHandler> logger)
        {
            _repositorioSuppliers = repositorioSuppliers;
            _logger = logger;
        }

        public async Task<CheckSuppliersExistsBySupplierNameResponse> Handle(CheckSuppliersExistsBySupplierNameRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckSuppliersExistsBySupplierNameRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckSuppliersExistsBySupplierNameRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioSuppliers.GetBySupplierName(request.SupplierName);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckSuppliersExistsBySupplierNameResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckSuppliersExistsBySupplierNameResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckSuppliersExistsBySupplierNameResponse(request.Id, false, validationResult));
        }
    }
}
