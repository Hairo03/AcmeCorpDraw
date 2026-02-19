using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.Domain.Models;
using AcmeCorpDraw.WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AcmeCorpDraw.WebApp.Repositories
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly AcmeDbContext _context;

        public SubmissionRepository(AcmeDbContext context)
        {
            // Inject DbContext from DI container
            _context = context;
        }

        public async Task AddAsync(Submission submission)
        {
            _context.Submissions.Add(submission);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Submission>> GetAllAsync()
        {
            return await _context.Submissions
                .OrderByDescending(s => s.SubmittedAt)
                .ToListAsync();
        }

        public async Task<int> CountBySerialAsync(string serialNumber)
        {
            return await _context.Submissions
                .CountAsync(s => s.SerialNumber == serialNumber.ToUpperInvariant());
        }

        public async Task<Submission> GetByIdAsync(int id)
        {
            return await _context.Submissions.FindAsync(id);
        }
    }
}
