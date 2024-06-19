﻿using NetDevPack.Domain;
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
        [Required]
        public string? Value { get; private set; }

        [Required]
        public string? IPAddress { get; private set; }
    }
}
