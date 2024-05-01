﻿using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Administration
{
    public class City : Entity, IAggregateRoot
    {
        public string? CityName { get; private set; }
    }
}
