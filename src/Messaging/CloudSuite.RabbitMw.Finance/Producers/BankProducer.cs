using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CloudSuite.RabbitMw.Finance.Producers
{
    public class BankProducer
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly RabbitMqSettings _settings;

        public BankProducer(RabbitMqSettings settings)
        {
            _settings = settings;
            var factory = new ConnectionFactory()
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
        }


    }
}
