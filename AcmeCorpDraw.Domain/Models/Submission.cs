using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeCorpDraw.Domain.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string SerialNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
