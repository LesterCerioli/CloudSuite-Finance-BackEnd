﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.RabbitMw.Finance
{
    public class RabbitMqSettings
    {
        public string? HostName { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? VirtualHost { get; set; }

        public string? ExchangeName { get; set; }

        public string? QueueName { get; set; }

        public string? RoutingKey { get; set; }
    }
}
