using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.RabbitMw.Finance
{
    public class RabbitMqSettings
    {
        public string HostName { get; set; } = "localhost";

        public string QueueName { get; set; } = "addressQueue";

        public string ExchangeName { get; set; } = "addressExchange";

        public string RoutingKey { get; set; } = "addressRoutingKey";
    }
}
