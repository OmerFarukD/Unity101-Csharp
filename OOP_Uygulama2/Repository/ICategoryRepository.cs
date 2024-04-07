using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public interface ICategoryRepository
{
    void Add(Category category);
    List<Category> GetAll();

    Category GetById(int id);
    void Delete(int id);
}
