using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Application.Validations.Invoices;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CheckInvoiceExistsByInvoiceStatusHandler : IRequestHandler<CheckInvoiceExistsByInvoiceStatusRequest, CheckInvoiceExistsByInvoiceStatusResponse>
    {
        private IInvoiceRepository _repositorioInvoice;
        private readonly ILogger<CheckInvoiceExistsByAmountHandler> _logger;

        public CheckInvoiceExistsByInvoiceStatusHandler(IInvoiceRepository repositorioInvoice, ILogger<CheckInvoiceExistsByAmountHandler> logger)
        {
            _repositorioInvoice = repositorioInvoice;
            _logger = logger;
        }

        public async Task<CheckInvoiceExistsByInvoiceStatusResponse> Handle(CheckInvoiceExistsByInvoiceStatusRequest request, CancellationToken cancellationToken)
        {
             _logger.LogInformation($"CheckInvoiceExistsByInvoiceStatusRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckInvoiceExistsByInvoiceStatusRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioInvoice.GetByInvoiceStatus(request.InvoiceStatus);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckInvoiceExistsByInvoiceStatusResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckInvoiceExistsByInvoiceStatusResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckInvoiceExistsByInvoiceStatusResponse(request.Id, false, validationResult));
        }
    }
}
