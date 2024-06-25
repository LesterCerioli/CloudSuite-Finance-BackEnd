using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CheckInvoiceExistsByAmountHandler : IRequestHandler<CheckInvoiceExistsByAmountRequest, CheckInvoiceExistsByAmountResponse>
    {
        private IInvoiceRepository _repositorioInvoice;
        private readonly ILogger<CheckInvoiceExistsByAmountHandler> _logger;

        public CheckInvoiceExistsByAmountHandler(IInvoiceRepository repositorioInvoice, ILogger<CheckInvoiceExistsByAmountHandler> logger)
        {
            _repositorioInvoice = repositorioInvoice;
            _logger = logger;
        }

        public async Task<CheckInvoiceExistsByAmountResponse> Handle(CheckInvoiceExistsByAmountRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckInvoiceExistsByAmountRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckInvoiceExistsByAmountRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioInvoice.GetByAmount(request.Amount);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckInvoiceExistsByAmountResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckInvoiceExistsByAmountResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckInvoiceExistsByAmountResponse(request.Id, false, validationResult));
        }
    }
}
