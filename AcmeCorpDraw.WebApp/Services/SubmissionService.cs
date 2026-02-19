using AcmeCorpDraw.Domain.DTOs;
using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.Domain.Models;

namespace AcmeCorpDraw.WebApp.Services
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISubmissionRepository _submissionRepository;
        private readonly ISerialNumberRepository _serialNumberRepository;
        private const int MaxEntriesPerSerial = 2;

        public SubmissionService(ISubmissionRepository submissionRepository, ISerialNumberRepository serialNumberRepository)
        {
            _submissionRepository = submissionRepository;
            _serialNumberRepository = serialNumberRepository;
        }

        public async Task<(bool Success, string? ErrorMessage, Submission? Submission)> CreateSubmissionAsync(SubmissionDTO dto)
        {
            if (await _serialNumberRepository.IsValidAsync(dto.SerialNumber) == false)
            {
                return (false, "Invalid serial number.", null);
            }

            var existingCount = await _submissionRepository.CountBySerialAsync(dto.SerialNumber);
            if (existingCount >= MaxEntriesPerSerial)
            {
                return (false, "Maximum entries for this serial number reached.", null);
            }

            var submission = new Submission
            {
                FirstName = dto.FirstName.Trim(),
                LastName = dto.LastName.Trim(),
                Email = dto.Email.Trim(),
                SerialNumber = dto.SerialNumber.Trim().ToUpperInvariant(),
                DateOfBirth = dto.DateOfBirth,
                SubmittedAt = DateTime.UtcNow
            };

            await _submissionRepository.AddAsync(submission);

            return (true, null, submission);
        }

        public async Task<IEnumerable<Submission>> GetAllSubmissionsAsync()
        {
            return await _submissionRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Submission>> GetSubmissionsPageAsync(int pageNumber, int pageSize)
        {
            return await _submissionRepository.GetPageAsync(pageNumber, pageSize);
        }

        public async Task<int> GetSubmissionCountBySerialAsync(string serialNumber)
        {
            return await _submissionRepository.CountBySerialAsync(serialNumber);
        }

        public async Task<Submission> GetSubmissionByIdAsync(int id)
        {
            return await _submissionRepository.GetByIdAsync(id);
        }

        public async Task<int> GetSubmissionCountAsync()
        {
            return await _submissionRepository.GetCountAsync();
        }
    }
}
