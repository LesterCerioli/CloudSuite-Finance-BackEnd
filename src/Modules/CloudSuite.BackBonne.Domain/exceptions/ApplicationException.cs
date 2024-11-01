﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.exceptions
{
    public abstract class ApplicationException : Exception
    {
        public ApplicationException(string? message) : base(message)
        {
        }

        protected ApplicationException(string title, string message)
            : base(message) =>
            Title = title;

        public string Title { get; }
    }
}
