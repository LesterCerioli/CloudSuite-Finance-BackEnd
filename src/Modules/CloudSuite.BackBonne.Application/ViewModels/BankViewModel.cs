using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class BankViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [DisplayName("CodeBank")]
        [MaxLength(3)]
        public int? Codebank { get; set; }

        [DisplayName("BankName")]
        [MaxLength(50)]
        public string? BankName { get; set; }
    }
}
