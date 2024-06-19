using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class Credential : Entity, IAggregateRoot
    {
        [Required]
        public string? Login { get; private set; }

        [Required]
        public string? Password { get; private set; }

        [Required]
        public string? IPAddress { get; private set; }
    }
}
