using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Requests;
using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.BackBonne.Application.Validations.Payments;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments
{
    public class CheckPaymentExistsByPaymentMethodHandler : IRequestHandler<CheckPaymentExistsByPaymentMethodRequest, CheckPaymentExistsByPaymentMethodResponse>
    {

        private IPaymentRepository _repositorioPayment;
        private readonly ILogger<CheckPaymentExistsByPaymentMethodHandler> _logger;

        public CheckPaymentExistsByPaymentMethodHandler(IPaymentRepository repositorioPayment, ILogger<CheckPaymentExistsByPaymentMethodHandler> logger)
        {
            _repositorioPayment = repositorioPayment;
            _logger = logger;
        }

        public async Task<CheckPaymentExistsByPaymentMethodResponse> Handle(CheckPaymentExistsByPaymentMethodRequest request, CancellationToken cancellationToken)
        {

            _logger.LogInformation($"CheckPaymentExistsByPaymentMethodRequest: {JsonSerializer.Serialize(request)}");
            var validationResult = new CheckPaymentExistsByPaymentMethodRequestValidation().Validate(request);

            if (validationResult.IsValid)
            {
                try
                {
                    var invoice = await _repositorioPayment.GetByPaymentMethod(request.PaymentMethod);
                    if (invoice != null)
                    {
                        return await Task.FromResult(new CheckPaymentExistsByPaymentMethodResponse(request.Id, true, validationResult));
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CheckPaymentExistsByPaymentMethodResponse(request.Id, " Não foi possível processar a solicitação."));
                }
            }
            return await Task.FromResult(new CheckPaymentExistsByPaymentMethodResponse(request.Id, false, validationResult));
        }
    }
}
