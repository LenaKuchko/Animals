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
    }
  }
}
