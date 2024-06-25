using CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments.Responses;
using CloudSuite.BackBonne.Domain.contracts.DownloadBills;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CloudSuite.BackBonne.Application.Handlers.DocumentBills.Payments
{
    public class CreatePaymentHandler : IRequestHandler<CreatePaymentCommand, CreatePaymentResponse>
    {

        private IPaymentRepository _repositorioPayment;

        private readonly ILogger<CreatePaymentHandler> _logger;

        public CreatePaymentHandler(IPaymentRepository repositorioPayment, ILogger<CreatePaymentHandler> logger)
        {
            _repositorioPayment = repositorioPayment;
            _logger = logger;
        }

        public async Task<CreatePaymentResponse> Handle(CreatePaymentCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreatePaymentCommand: {JsonSerializer.Serialize(command)}");
            var validationResult = new CreatePaymentCommandValidation().Validate(command);

            if (validationResult.IsValid)
            {
                try
                {
                    var paymentAmount = await _repositorioPayment.GetByAmount(command.Amount);
                    var paymentDate = await _repositorioPayment.GetByPaymentDate(command.PaymentDate);
                    var paymentMethod = await _repositorioPayment.GetByPaymentMethod(command.PaymentMethod);

                    if (paymentAmount != null && paymentDate != null && paymentMethod != null)
                    {
                        return await Task.FromResult(new CreatePaymentResponse(command.Id, "Pagamento já criado."));
                    }

                    await _repositorioPayment.Add(command.GetEntity());
                    return await Task.FromResult(new CreatePaymentResponse(command.Id, validationResult));
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    return await Task.FromResult(new CreatePaymentResponse(command.Id, "Não foi possível processar a solicitação."));
                }
            }

            return await Task.FromResult(new CreatePaymentResponse(command.Id, validationResult));
        }
    }
}
