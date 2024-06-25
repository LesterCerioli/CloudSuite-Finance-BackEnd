using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments
{
    public class CheckPaymentExistsByPaymentDateHandler : IRequestHandler<CheckPaymentExistsByPaymentDateRequest, CheckPaymentExistsByPaymentDateResponse>
    {

        private IPaymentRepository _repositorioPayment;
        private readonly ILogger<CheckPaymentExistsByPaymentDateHandler> _logger;

        public CheckPaymentExistsByPaymentDateHandler(IPaymentRepository repositorioPayment, ILogger<CheckPaymentExistsByPaymentDateHandler> logger)
        {
            _repositorioPayment = repositorioPayment;
            _logger = logger;
        }

        public async Task<CheckPaymentExistsByPaymentDateResponse> Handle(CheckPaymentExistsByPaymentDateRequest request, CancellationToken cancellationToken)
        {

            _logger.LogInformation($"CheckPaymentExistsByPaymentDateRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckPaymentExistsByPaymentDateRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioPayment.GetByPaymentDate(request.PaymentDate);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckPaymentExistsByPaymentDateResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckPaymentExistsByPaymentDateResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckPaymentExistsByPaymentDateResponse(request.Id, false, validationResult));
        }
    }
}
