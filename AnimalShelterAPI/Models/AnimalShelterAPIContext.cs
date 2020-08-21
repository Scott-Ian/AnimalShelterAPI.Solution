using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
      : base(options)
    {
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          
          new Cat {
            CatId = 249017, 
            Name = "Domino", 
            Breed = "Domestic Medium Hair",
            Sex = Sex.Male,
            Coloring = "Black",
            Age = 2,
            Weight = 11.8,
            Personality = Personality.Kind,
            About = "Love Cheek and Chin Scratches!",
            Adopted = false,
            },

            new Cat {
            CatId = 249281, 
            Name = "Doug", 
            Breed = "Domestic Short Hair",
            Sex = Sex.Male,
            Coloring = "Brown Tabby",
            Age = 0.3,
            Weight = 5.2,
            Personality = Personality.Playful,
            About = "Always PURRing and PURRfect!",
            Adopted = false,
            },

            new Cat {
            CatId = 249318, 
            Name = "Bunny", 
            Breed = "Domestic Short Hair",
            Sex = Sex.Male,
            Coloring = "Blue Tabby",
            Age = 2,
            Weight = 7.4,
            Personality = Personality.Shy,
            About = "Anxious around new animals and people, but very sweet!",
            Adopted = false,
            }
        );

      builder.Entity<Dog>()
        .HasData(
          
          new Dog {
            DogId = 248680, 
            Name = "Angus", 
            Breed = "Labrador",
            Sex = Sex.Male,
            Coloring = "Yellow",
            Age = 7,
            Weight = 101.3,
            Personality = Personality.Adventerous,
            About = "Playful biter, loves chassing rabbits!",
            Adopted = false,
            },

            new Dog {
            DogId = 227248, 
            Name = "Penny", 
            Breed = "American Pit Bull - Australian Shepherd",
            Sex = Sex.Female,
            Coloring = "White Brown",
            Age = 1.9,
            Weight = 52.1,
            Personality = Personality.Sassy,
            About = "A true HomeBuddy! Knows many tricks and is a quick learner!",
            Adopted = false,
            },

            new Dog {
            DogId = 249396, 
            Name = "Churro", 
            Breed = "Dachsund",
            Sex = Sex.Male,
            Coloring = "Red White",
            Age = 1.5,
            Weight = 15,
            Personality = Personality.Grumpy,
            About = "Love to Learn and Love to Cuddle. Netflix and Chill?",
            Adopted = false,
            }
        );
    }
  }
}