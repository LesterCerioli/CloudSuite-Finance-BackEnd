using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CloudSuite.RabbitMw.Finance.Consumers
{
    public class AddressConsumer : BackgroundService
    {
        private readonly RabbitMqSettings _settings;
        private readonly ILogger<AddressConsumer> _logger;
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public AddressConsumer(RabbitMqSettings settings, ILogger<AddressConsumer> logger)
        {
            _settings = settings;
            _logger = logger;

            var factory = new ConnectionFactory() { HostName = _settings.HostName };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare(exchange: _settings.ExchangeName, type: "direct");
            _channel.QueueDeclare(queue: _settings.QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: _settings.QueueName, exchange: _settings.ExchangeName, routingKey: _settings.RoutingKey);

        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}
