using MVC.Basic.Attributes.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Basic.Models
{
    public class Motorcycle
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "Please enter Id")]
        public int Id { get; set; }

        [MinLength(3)]
        public string Brand { get; set; }
        public string Model { get; set; }
        public ushort Value { get; set; }

        [RequireGuidFormat(ErrorMessage = "Should be GUID structure")]
        public ushort MaxSpeed { get; set; }
        public double Price { get; set; }
    }
}
