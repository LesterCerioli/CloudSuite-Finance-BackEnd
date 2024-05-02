using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class FactorViewModel
    {
        public Guid Id { get; private set; }

        [DisplayName("Purpose")]
        public string? Purpose { get; set; }
    }
}
