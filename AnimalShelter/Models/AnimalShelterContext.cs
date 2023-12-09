using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Beethoven", Species = "Dog", Color = "Black & Tan", Age = 2 },
          new Animal { AnimalId = 2, Name = "Garfield", Species = "Cat", Color = "Orange", Age = 3 },
          new Animal { AnimalId = 3, Name = "Marley", Species = "Dog", Color = "Tan", Age = 4 },
          new Animal { AnimalId = 4, Name = "Fido", Species = "Dog", Color = "Brindle", Age = 1 },
          new Animal { AnimalId = 5, Name = "Smokey", Species = "Cat", Color = "Grey", Age = 4 },
          new Animal { AnimalId = 6, Name = "Cujo", Species = "Dog", Color = "Black", Age = 1 },
          new Animal { AnimalId = 7, Name = "Cali", Species = "Cat", Color = "Calico", Age = 2 },
          new Animal { AnimalId = 8, Name = "Bud", Species = "Dog", Color = "Golden", Age = 6 },
          new Animal { AnimalId = 9, Name = "Clifford", Species = "Dog", Color = "Red", Age = 1 },
          new Animal { AnimalId = 10, Name = "Tom", Species = "Cat", Color = "Tuxedo", Age = 4 }
        );
    }
  }
}

