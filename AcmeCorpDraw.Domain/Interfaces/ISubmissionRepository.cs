using AcmeCorpDraw.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeCorpDraw.Domain.Interfaces
{
    public interface ISubmissionRepository
    {
        Task AddAsync(Submission submission);
        Task<IEnumerable<Submission>> GetAllAsync();
        Task<int> CountBySerialAsync(string serialNumber);
        Task<Submission> GetByIdAsync(int id);
    }
}
