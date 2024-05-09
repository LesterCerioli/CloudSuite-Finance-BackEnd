using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class AccountViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [DisplayName("AccountNumber")]
        [MinLength(03)]
        [MaxLength(14)]
        public string? AccountNumber { get; set; }

        [DisplayName("AccountDigit")]
        public int? AccountDigit { get; set; }
    }
}
