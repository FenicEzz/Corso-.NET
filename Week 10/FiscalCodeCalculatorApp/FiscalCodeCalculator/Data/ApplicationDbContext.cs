using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataLayer;

namespace FiscalCodeCalculator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DataLayer.City> City { get; set; } = default!;
        public DbSet<DataLayer.User> User { get; set; } = default!;
    }
}