using Nancy;
using System.Collections.Generic;
using Animals.Objects;
namespace Animals
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Category> categories = Category.GetAllCategories();
        return View["index.cshtml", categories];
      };
      Post["/"] = _ => {
        Category category = new Category(Request.Form["new_category"]);
        return View["index.cshtml", Category.GetAllCategories()];
      };
      Get["/category/{id}"] = _ => parameters {
        Dictionary<string, object> = new Dictionary<string, object>{};
         Category category = Category.FindCategory(parameters.id);
         List<Animal> animals = category.GetCategoryAnimals();
        return View["show_category_animals.cshtml", should be dictionary];
      };
    }
  }
}
