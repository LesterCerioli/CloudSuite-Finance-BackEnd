using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Invoices
{
    public class CreateInvoiceHandler : IRequestHandler<CreateInvoiceCommand, CreateInvoiceResponse>
    {
        private IInvoiceRepository _repositorioInvoice;
        private readonly ILogger<CreateInvoiceHandler> _logger;

        public CreateInvoiceHandler(IInvoiceRepository repositorioInvoice, ILogger<CreateInvoiceHandler> logger)
        {
            _repositorioInvoice = repositorioInvoice;
            _logger = logger;
        }

        public async Task<CreateInvoiceResponse> Handle(CreateInvoiceCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateSubscriptionCommand: {JsonSerializer.Serialize(command)}");
            var validationResult = new CreateSubscriptionCommandValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoiceAmount = await _repositorioInvoice.GetByAmount(command.Amount);
                    var invoiceDueDate = await _repositorioInvoice.GetByDueDate(command.DueDate);
                    var invoiceInvoiceStatus = await _repositorioInvoice.GetByInvoiceStatus(command.Status);
                    var invoicePaymentDate = await _repositorioInvoice.GetByPaymentDate(command.PaymentDate);

                    if (invoiceAmount != null && invoiceDueDate != null && invoiceInvoiceStatus != null && invoicePaymentDate != null)
                    {
                        return await Task.FromResult(new CreateInvoiceResponse(command.Id, "Invoice já criada."));
                    }

                    await _repositorioInvoice.Add(command.GetEntity());
                    return await Task.FromResult(new CreateInvoiceResponse(command.Id, validationResult));
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CreateInvoiceResponse(command.Id, "Não foi possível processar a solicitação."));
                }
            }

            return await Task.FromResult(new CreateInvoiceResponse(command.Id, validationResult));
        }
    }
}
