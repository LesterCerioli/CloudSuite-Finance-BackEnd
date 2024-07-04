using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Application.Validations.Invoices;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{ 
    public class CheckInvoiceExistsByDueDateHandler : IRequestHandler<CheckInvoiceExistsByDueDateRequest, CheckInvoiceExistsByDueDateResponse>
    {
        private IInvoiceRepository _repositorioInvoice;
        private readonly ILogger<CheckInvoiceExistsByDueDateHandler> _logger;

        public CheckInvoiceExistsByDueDateHandler(IInvoiceRepository repositorioInvoice, ILogger<CheckInvoiceExistsByDueDateHandler> logger)
        {
            _repositorioInvoice = repositorioInvoice;
            _logger = logger;
        }

        public async Task<CheckInvoiceExistsByDueDateResponse> Handle(CheckInvoiceExistsByDueDateRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CheckInvoiceExistsByDueDateRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckInvoiceExistsByDueDateRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioInvoice.GetByDueDate(request.DueDate);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckInvoiceExistsByDueDateResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckInvoiceExistsByDueDateResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckInvoiceExistsByDueDateResponse(request.Id, false, validationResult));
        }
    }
}
