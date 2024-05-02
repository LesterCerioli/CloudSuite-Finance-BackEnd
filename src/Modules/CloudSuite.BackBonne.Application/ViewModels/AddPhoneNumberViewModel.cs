using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class AddPhoneNumberViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string? Number { get; set; }
    }
}
