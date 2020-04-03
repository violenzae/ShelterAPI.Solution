using Microsoft.EntityFrameworkCore;

namespace ShelterAPI.Models
{
  public class ShelterAPIContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Bert", Species = "Cat", Breed = "Bobtail", Age = 3, Gender = "Male" },
          new Animal { AnimalId = 2, Name = "Alice", Species = "Cat", Breed ="Siamese", Age = 8, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "Alfred", Species = "Cat", Breed ="Shorthair", Age = 1, Gender = "Male" },
          new Animal { AnimalId = 4, Name = "Margo", Species = "Cat", Breed = "Maine Coon", Age = 4, Gender = "Female" },
          new Animal { AnimalId = 5, Name = "Andrew", Species = "Dog", Breed = "Dachsund", Age = 12, Gender = "Male" },
          new Animal { AnimalId = 6, Name = "Eduardo", Species = "Dog", Breed = "Mixed", Age = 6, Gender = "Male" },
          new Animal { AnimalId = 7, Name = "Angela", Species = "Dog", Breed = "Shih Tzu", Age = 4, Gender = "Female"},
          new Animal { AnimalId = 8, Name = "Bingo", Species = "Dog", Breed = "Dalmation", Age = 10, Gender = "Male"}
        );
    }
    public ShelterAPIContext(DbContextOptions<ShelterAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  }
}