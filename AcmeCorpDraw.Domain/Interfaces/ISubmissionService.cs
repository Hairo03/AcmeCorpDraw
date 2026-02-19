using AcmeCorpDraw.Domain.DTOs;
using AcmeCorpDraw.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeCorpDraw.Domain.Interfaces
{
    public interface ISubmissionService
    {
        // Returns a tuple so it's easier to handle success/failure
        Task<(bool Success, string? ErrorMessage, Submission? Submission)> CreateSubmissionAsync(SubmissionDTO dto);
        Task<IEnumerable<Submission>> GetAllSubmissionsAsync();

        Task<int> GetSubmissionCountBySerialAsync(string serialNumber);

        Task<Submission> GetSubmissionByIdAsync(int id);
    }
}
