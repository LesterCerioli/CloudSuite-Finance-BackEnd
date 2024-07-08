﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService
{
    public class WorkPermit: NetDevPack.Domain.ValueObject
    {
        public int? WorkPermitId { get; set; }
        public string? Number { get; set; }
        public string? Series { get; set; }
        public int? UfId { get; set; }
        public DateTime? dtExpedition { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}   