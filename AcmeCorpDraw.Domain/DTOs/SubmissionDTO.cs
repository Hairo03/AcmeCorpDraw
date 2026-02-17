using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcmeCorpDraw.Domain.DTOs
{
    public class SubmissionDTO
    {
        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string SerialNumber { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
