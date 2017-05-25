using System;
using System.Collections.Generic;
namespace Animals.Objects
{
  public class Category
  {
    private static List<Category> _lists = new List<Category> {};
    private string _categoryName;
    private int _id;
    private List<Animal> _animals = new List<Animal> {};

    public Category(string name)
    {
      _categoryName = name;
      _lists.Add(this);
      _id = _lists.Count;
    }

    public string GetCategoryName()
    {
      return _categoryName;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Category> GetAllCategories()
    {
      return _lists;
    }
    public List<Animal> GetCategoryAnimals()
    {
      return _animals;
    }
    public static Category FindCategory(int SearchId)
    {
      return _lists[SearchId-1];
    }
  }
}
