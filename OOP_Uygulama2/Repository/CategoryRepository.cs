using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public class CategoryRepository : ICategoryRepository
{
   private List<Category> _categories;

    public CategoryRepository()
    {
        _categories = new List<Category>()
        {
          new Category(1,"Türk klasikleri"),
          new Category(2,"Dünya Klasikleri"),
          new Category(3,"Bilim Kurgu")
    };
    }


    public void Add(Category category)
    {
       _categories.Add(category);
    }

    public void Delete(int id)
    {
        Category? category = _categories.SingleOrDefault(x=> x.Id ==id);
        if(category == null)
        {
            // Exception fırlat
        }
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        Category? category = _categories.SingleOrDefault(x => x.Id == id);
        if (category == null)
        {
            // Exception fırlat
        }
        return category;
    }
}
