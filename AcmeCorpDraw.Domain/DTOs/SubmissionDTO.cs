using AcmeCorpDraw.Domain.DTOs.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcmeCorpDraw.Domain.DTOs
{
    public class SubmissionDTO
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Serial number is required")]
        [StringLength(20, ErrorMessage = "Serial number cannot exceed 20 characters")]
        public string SerialNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required")]
        [MinimumAge(18)]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
