using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels.AdviceService
{
    public class InvestmentViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Registo de Contribuintes")]
        [Required(ErrorMessage = "O {0} campo deve ser preenchido.")]
        public string TaxPayerRegistry { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O {0} campo deve ser preenchido.")]
        public string Name { get; set; }

        [DisplayName("Perfil de investimento")]
        [Required(ErrorMessage = "O {0} campo deve ser preenchido.")]
        public string InvestmentProfile { get; set; }
    }
}