using Microsoft.EntityFrameworkCore;
using AcmeCorpDraw.Domain.Models;


namespace AcmeCorpDraw.WebApp.Data
{
    public class AcmeDbContext : DbContext
    {
        public AcmeDbContext(DbContextOptions<AcmeDbContext> options) : base(options)
        {
        }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
    }
}
