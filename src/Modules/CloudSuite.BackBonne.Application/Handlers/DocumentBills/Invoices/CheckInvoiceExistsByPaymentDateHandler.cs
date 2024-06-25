using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Application.Validations.Invoices;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CheckInvoiceExistsByPaymentDateHandler : IRequestHandler<CheckInvoiceExistsByPaymentDateRequest, CheckInvoiceExistsPaymentDateResponse>
    {

        private IInvoiceRepository _repositorioInvoice;
        private readonly ILogger<CheckInvoiceExistsByAmountHandler> _logger;

        public CheckInvoiceExistsByPaymentDateHandler(IInvoiceRepository repositorioInvoice, ILogger<CheckInvoiceExistsByAmountHandler> logger)
        {
            _repositorioInvoice = repositorioInvoice;
            _logger = logger;
        }

        public async Task<CheckInvoiceExistsPaymentDateResponse> Handle(CheckInvoiceExistsByPaymentDateRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckInvoiceExistsByPaymentDateRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckInvoiceExistsByPaymentDateRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioInvoice.GetByPaymentDate(request.PaymentDate);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckInvoiceExistsPaymentDateResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckInvoiceExistsPaymentDateResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckInvoiceExistsPaymentDateResponse(request.Id, false, validationResult));
        }
    }
}
