using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments
{
    public class CheckPaymentExistsByAmountHandler : IRequestHandler<CheckPaymentExistsByAmountRequest, CheckPaymentExistsByAmountResponse>
    {

        private IPaymentRepository _repositorioPayment;
        private readonly ILogger<CheckPaymentExistsByAmountHandler> _logger;

        public CheckPaymentExistsByAmountHandler(IPaymentRepository repositorioPayment, ILogger<CheckPaymentExistsByAmountHandler> logger)
        {
            _repositorioPayment = repositorioPayment;
            _logger = logger;
        }

        public async Task<CheckPaymentExistsByAmountResponse> Handle(CheckPaymentExistsByAmountRequest request, CancellationToken cancellationToken)
        {

            _logger.LogInformation($"CheckPaymentExistsByAmountRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckPaymentExistsByAmountRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioPayment.GetByAmount(request.Amount);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckPaymentExistsByAmountResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckPaymentExistsByAmountResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckPaymentExistsByAmountResponse(request.Id, false, validationResult));
        }
    }
}
