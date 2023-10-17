using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreJQuery.Helpers
{
	public class MyCustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Custom error");
        }
    }
}

