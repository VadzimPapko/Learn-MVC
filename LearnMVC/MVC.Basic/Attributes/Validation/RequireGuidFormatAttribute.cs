using MVC.Basic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Basic.Attributes.Validation
{
    public class RequireGuidFormatAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = Guid.TryParse(value.ToString(), out _);
            
            return isValid;
        }

        //Just FYI
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
