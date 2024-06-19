using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CloudSuite.RabbitMw.Finance.Consumers
{
    public class AccountConsumer : BackgroundService
    {
        private readonly RabbitMqSettings _settings;
        private readonly ILogger<AccountConsumer> _logger;
        private IConnection _connection;
        private IModel _channel;
        private EventingBasicConsumer _consumer;
        private readonly int _retryCount = 3;

        public AccountConsumer(IOptions<RabbitMqSettings> options, ILogger<AccountConsumer> logger)
        {
            _settings = options.Value;
            _logger = logger;
            InitializeRabbitMqListener();
        }

        private void InitializeRabbitMqListener()
        {
            var factory = new ConnectionFactory
            {
                HostName = _settings.HostName,
                UserName = _settings.UserName,
                Password = _settings.Password,
                VirtualHost = _settings.VirtualHost
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare(exchange: _settings.ExchangeName, type: "direct");
            _channel.QueueDeclare(queue: _settings.QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: _settings.QueueName, exchange: _settings.ExchangeName, routingKey: _settings.RoutingKey);

            _consumer = new EventingBasicConsumer(_channel);
            _consumer.Received += async (model, ea) =>
            {
                try
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);

                    await ProcessMessageAsync(message);

                    _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error processing message");
                    _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: true);
                }
            };
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.Register(() => _logger.LogInformation("Stopping RabbitMQ listener."));
            _channel.BasicConsume(queue: _settings.QueueName, autoAck: false, consumer: _consumer);
            return Task.CompletedTask;
        }

        private async Task ProcessMessageAsync(string message)
        {
            _logger.LogInformation($"Received message: {message}");
            
            await Task.CompletedTask;
        }

        public override void Dispose()
        {
            _channel?.Dispose();
            _connection?.Dispose();
            base.Dispose();
        }

        private void Reconnect()
        {
            int retryAttempt = 0;
            while (retryAttempt < _retryCount)
            {
                try
                {
                    InitializeRabbitMqListener();
                    _logger.LogInformation("Reconnected to RabbitMQ.");
                    return;
                }
                catch (Exception ex)
                {
                    retryAttempt++;
                    _logger.LogError(ex, "Failed to reconnect to RabbitMQ. Retrying in 5 seconds...");
                    Thread.Sleep(5000);
                }
            }

            _logger.LogError("Could not reconnect to RabbitMQ after multiple attempts.");
        }

        private void ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            _logger.LogWarning("RabbitMQ connection shutdown. Attempting to reconnect...");
            Reconnect();
        }
    }
}
