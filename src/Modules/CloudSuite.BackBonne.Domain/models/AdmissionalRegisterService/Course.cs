using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdmissionalRegisterService.Model
{
    public class Course : Entity, IAggregateRoot 
    {
        public Course( string? name)
        {
            Name = name; 

        }
        
         public Course() { }

        public string? Name { get; set; }

    } 
}   