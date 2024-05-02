using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string? Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string? Password { get; set; }

        [DisplayName("RemeberMe")]
        public bool? RememberMe { get; set; }
    }
}
