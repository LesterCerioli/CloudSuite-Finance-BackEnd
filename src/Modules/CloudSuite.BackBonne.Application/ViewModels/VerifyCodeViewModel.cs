using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class VerifyCodeViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public string? Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [DisplayName("ReturnUrl")]
        public string? ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool? RememberBrowser { get; set; }

        public bool? RememberMe { get; set; }
    }
}
