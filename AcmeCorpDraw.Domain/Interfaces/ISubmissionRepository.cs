using AcmeCorpDraw.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeCorpDraw.Domain.Interfaces
{
    public interface ISubmissionRepository
    {
        Task AddSubmissionAsync(Submission submission);
        Task<IEnumerable<Submission>> GetAllAsync();
        Task<int> CountBySerialAsync(string serialNumber);
    }
}
