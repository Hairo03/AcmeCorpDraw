using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AcmeCorpDraw.WebApp.Repositories
{
    public class SerialNumberRepository : ISerialNumberRepository
    {
        private readonly AcmeDbContext _context;

        public SerialNumberRepository(AcmeDbContext context)
        {
            // Inject DbContext from DI container
            _context = context;
        }

        public async Task<bool> IsValidAsync(string serialNumber)
        {
            return await _context.SerialNumbers
                .AnyAsync(s => s.Number == serialNumber.ToUpperInvariant());
        }
    }
}
