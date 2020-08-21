using System;

namespace AnimalShelterAPI.Models
{
  public abstract class Animal
  {
    public string Name { get; set; }
    public string Breed { get; set; }
    public Sex Sex { get; set; }
    public string Coloring { get; set; }
    public double Age{ get; set; }
    public double Weight { get; set; }
    public Personality Personality { get; set; }
    public string About { get; set; }
    public bool Adopted { get; set; }
    public DateTime AdoptionDate { get; set; }

  }

  public enum Sex
  {
    Male,
    Female
  }

  public enum Personality
  {
    Grumpy,
    Sassy,
    Sweet,
    Kind,
    Playful,
    Shy,
    Adventerous,
    Energetic
  }
}