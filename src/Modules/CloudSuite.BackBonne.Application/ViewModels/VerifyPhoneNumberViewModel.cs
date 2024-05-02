using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class VerifyPhoneNumberViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [Display(Name = "Code")]
        public string? Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}
