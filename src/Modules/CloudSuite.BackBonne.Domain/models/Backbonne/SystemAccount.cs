using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.Backbonne
{
    public class SystemAccount
    {
        public string? Name { get; private set; }
        public string? Address { get; private set; }
        public bool? IsProper { get; private set; }
    }
}
