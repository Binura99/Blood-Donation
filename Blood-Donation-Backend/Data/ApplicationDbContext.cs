using Blood_Donation_Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blood_Donation_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        
        }

        public DbSet<User> Users { get; set; }
    }
}
