using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class ConfigureTwoFactorViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [DisplayName("SelectedProvider")]
        public string? SelectedProvider { get; set; }
    }
}
