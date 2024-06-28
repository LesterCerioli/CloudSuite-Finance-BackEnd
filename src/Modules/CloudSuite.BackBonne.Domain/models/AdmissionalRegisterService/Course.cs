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
        public Course(int? courseId, string? name)
        {
            CourseId = courseId;
            Name = name;
        }
        
         public Course() { }

        public int? CourseId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(100)]
        public string? Name { get; set; }

    } 
}  