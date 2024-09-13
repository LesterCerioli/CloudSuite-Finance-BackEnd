using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class Token : Entity, IAggregateRoot
    {
        
        public string? Value { get; private set; }

        public string? IPAddress { get; private set; }
    }
}
