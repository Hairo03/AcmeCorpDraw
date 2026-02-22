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
        Task<IEnumerable<Submission>> GetPageAsync(int pageNumber, int pageSize);
        Task<int> CountBySerialAsync(string serialNumber);
        Task<int> GetCountAsync(); 
        Task<Submission> GetByIdAsync(int id);
    }
}
