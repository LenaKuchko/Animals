using System;
using System.Collections.Generic;
namespace Animals.Objects
{
  public class Animal
  {
    private static List<Animal> _allAnimals = new List<Animal> {};
    private string _animalName;
    private string _habitat;
    private int _animalId;

    public Animal(string name, string habitat)
    {
      _animalName = name;
      _habitat = habitat;
      _allAnimals.Add(this);
      _animalId = _allAnimals.Count;
    }
    public string GetAnimalName()
    {
      return _animalName;
    }
    public string GetHabitat()
    {
      return _habitat;
    }
    public int GetAnimalId()
    {
      return _animalId;
    }
  }
}
