using Microsoft.EntityFrameworkCore;

namespace ShelterAPI.Models
{
    public class ShelterAPIContext : DbContext
    {
        public ShelterAPIContext(DbContextOptions<ShelterAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}