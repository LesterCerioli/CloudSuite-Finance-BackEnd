﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Application.ViewModels
{
    public class ForgotViewModel
    {
        public Guid Id { get; private set; }

        [Required]
        [Display(Name = "Email")]
        public string? Email { get; set; }
    }
}
