using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcmeCorpDraw.Domain.DTOs.Validation
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        public int MinimumAge { get; } 

        public MinimumAgeAttribute(int minimumAge)
        {
            MinimumAge = minimumAge;
            ErrorMessage = $"You must be at least {minimumAge} years old to enter the draw.";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Check for null to avoid runtime errors when the value is not provided.
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is DateTime dateOfBirth)
            {
                var age = CalculateAge(dateOfBirth);
                if (age < MinimumAge)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;

            // Check if the birthday has happend this year. If not subtract one
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
