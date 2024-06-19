using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.RabbitMw.Finance
{
    public class MessagingConfiguration
    {
        public string? Hostname { get; set; }

        public string? QueueName { get; set; }
    }
}
